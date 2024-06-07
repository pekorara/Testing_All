using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Extension
{
    public static class DateTimeExtensions
    {
        public static int DaysBetween(this DateTime startDate, DateTime endDate)
        {
            return (endDate - startDate).Days;
        }
    }
}
