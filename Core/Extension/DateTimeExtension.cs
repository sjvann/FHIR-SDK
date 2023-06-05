using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extension
{
    public static class DateTimeExtension
    {
        public static int GetAge(this DateTime birthdate)
        {
            var today = DateTime.Now;
            var age = today.Year - birthdate.Year;
            if (birthdate.Date > today.AddYears(-age)) age--;
            return age;
        }
        public static int GetDays(this DateTime start, DateTime end)
        {
            var t = end.Subtract(start);
            int days = (int)t.TotalDays;
            return days < 0 ? -1 : days;
        }
        public static int GetChildAgeGroup(this DateTime birthdate)
        {
            var today = DateTime.Now;
            if (birthdate.GetAge() < 2)
            {
                if (today.Month - birthdate.Month < 6)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 0;
            }
        }
        public static DateTime GetFromTimestamp(this DateTime now, double timestamp)
        {
            return now.AddSeconds(timestamp);
        }
    }
}
