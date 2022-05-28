using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class DateTimeExtensions
    {
        public static string HowManyDays(this DateTime date)
        {
            System.TimeSpan diff = date.Subtract(DateTime.Now);

            if (diff.Seconds < 0)
            {
                return $"{Math.Abs(diff.Days)} Gün , {Math.Abs(diff.Hours)} Saat , {Math.Abs(diff.Seconds)} Saniye Olmuş.";
            }

            else {
                return $"{diff.Days} Gün , {diff.Hours} Saat , {diff.Seconds} Saniye Var.";
            }

           
            
        }
    }
}
