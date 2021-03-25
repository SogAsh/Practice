using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class LeapYear
    {
        public static bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 100 != 0 && year % 4 == 0;
        }
    }
}