using System;
using System.Text;

namespace SSSM.Common
{
    public static class Helper
    {
        public static int CalcAge(DateTime bday)
        {
            var tday = DateTime.Today;
            return tday.Year - bday.Year + ((tday.Month > bday.Month) || (tday.Month == bday.Month && tday.Day > bday.Day) ? 1 : 0);
        }

        public static int CalcAge(DateTime bday, DateTime tday)
        {
            return tday.Year - bday.Year + ((tday.Month > bday.Month) || (tday.Month == bday.Month && tday.Day > bday.Day) ? 1 : 0);
        }

        public static string ArbicNumberToChinese(int num)
        {
            return new[] { "〇", "一", "二", "三", "四", "五", "六", "七", "八", "九" }[num];
        }

        public struct SchoolClass
        {
            public int GradeIndex { get; set; }
            public int ClassIndex { get; set; }

            public override string ToString()
            {
                return $"{ArbicNumberToChinese(GradeIndex)}年级 ({ClassIndex}) 班";
            }
        }
    }
}
