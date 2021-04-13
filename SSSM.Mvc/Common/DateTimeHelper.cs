using System;

namespace SSSM.Common.Common
{
    public static class DateTimeHelper
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
    }
}
