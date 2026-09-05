using System;
using System.Collections.Generic;
using System.Text;

namespace TollFeeCalculator
{
    public static class TollFeeSchedule
    {
        public static bool IsTollFreeDate(DateTime date)
        {
            // Check if the date is a weekend (Saturday or Sunday)
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                return true;
            }
            // Check for public holidays (example: January 1st, December 25th)
            if ((date.Month == 1 && date.Day == 1) || (date.Month == 5 && date.Day == 1) || 
                (date.Month == 12 && (date.Day == 24 || date.Day == 25 || date.Day == 26 || date.Day == 31)))
            {
                return true;
            }
            return false;
        }
    }
}
