using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace CodePlayer
{
    class Common
    {
        public static int DateDecimal(DateTime dt)
        {
            return Convert.ToInt32(dt.ToString("yyyyMMdd"));
        }
        public static DateTime Today => DateTime.Today;
        public static int TodayDecimal => DateDecimal(Today);


        public const string CONNECTION_STRING = "Data Source=code.db";
        public static void InitTables()
        {
            using (var conn = new SQLiteConnection(CONNECTION_STRING))
            {
                conn.Execute("CREATE TABLE IF NOT EXISTS settings(Id text primary key,Value text);", new { });
                conn.Execute("CREATE TABLE IF NOT EXISTS codeitems(Id int primary key,Code text)", new { });
            }
        }

        public static void InsertOrUpdateCode(int date, string code)
        {
            using (var conn = new SQLiteConnection(CONNECTION_STRING))
            {
                CodeItem item = conn.Query<CodeItem>("SELECT * FROM codeitems WHERE Id=@id", new { id = date }).FirstOrDefault();
                if (item is null)
                {
                    item = new CodeItem { Id = date, Code = code };
                    conn.Execute("INSERT INTO codeitems(Id,Code) values(@Id,@Code)", item);
                }
                else
                {
                    if (item.Code != code)
                    {
                        item.Code = code;
                        conn.Execute("UPDATE codeitems SET Code=@Code WHERE Id=@Id", item);
                    }
                }
            }
        }
        public static List<CodeItem> GetCodes()
        {
            using (var conn = new SQLiteConnection(CONNECTION_STRING))
            {
                return conn.Query<CodeItem>("select * from codeitems ORDER BY Id DESC", new { }).ToList();
            }
        }
        public static CodeItem GetCode(int id)
        {
            using (var conn = new SQLiteConnection(CONNECTION_STRING))
            {
                return conn.Query<CodeItem>("SELECT * FROM codeitems WHERE Id=@id", new { id }).SingleOrDefault();
            }
        }
        public static void DeleteCodes(int start, int end)
        {
            using (var conn = new SQLiteConnection(CONNECTION_STRING))
            {
                conn.Execute("DELETE FROM codeitems WHERE Id BETWEEN @start AND @end", new { start, end });
            }
        }
        public static void DeleteCodes(int end)
        {
            using (var conn = new SQLiteConnection(CONNECTION_STRING))
            {
                conn.Execute("DELETE FROM codeitems WHERE Id<@end", new { end });
            }
        }
        public static void DeleteCodes()
        {
            using (var conn = new SQLiteConnection(CONNECTION_STRING))
            {
                conn.Execute("DELETE FROM codeitems", new { });
            }
        }

        public static void InsertOrUpdatePassword(string newpwd)
        {
            using (var conn = new SQLiteConnection(CONNECTION_STRING))
            {
                var item = conn.Query<SetItem>("SELECT * FROM settings WHERE Id=@id", new { id = "password" }).FirstOrDefault();
                if (item is null)
                {
                    item = new SetItem { Id = "password", Value = newpwd };
                    conn.Execute("INSERT INTO settings(Id,Value) values(@Id,@Value)", item);
                }
                else
                {
                    if (item.Value != newpwd)
                    {
                        item.Value = newpwd;
                        conn.Execute("update settings set Value=@Value where Id=@Id", item);
                    }
                }
            }
        }
        public static bool CheckPassword(string pwdstr)
        {
            using (var conn = new SQLiteConnection(CONNECTION_STRING))
            {
                if (conn.Execute("SELECT * FROM settings WHERE Id=@id", new { id = "password" }) == 0)
                {
                    conn.Execute("INSERT INTO settings(Id,Value) values(@id,@value)", new { id = "password", value = "11111111" });
                }
                return conn.Execute("SELECT * FROM settings WHERE Id=@id AND Value=@value", new { id = "password", value = pwdstr }) == 1;
            }
        }
    }
}
