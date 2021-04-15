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
            var leapyear = year % 400 == 0 || year % 4 == 0 && year % 100 != 0;

            return leapyear;

            /*
            2014 
            1999
            8992
            1
            14
            400
            600
            3200
            */
        }
    }
}
