using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class AverageOfThree
    {
        //public static int MiddleOf(int a, int b, int c)
        //{
        //    if ((a > b && b > c) || (c > b && b > a)) return b;
        //    if ((b > c && c > a) || (a > c && c > b)) return c;
        //    return a;


        //}

        public static int MiddleOf(int a, int b, int c)
        {
            if (a < b)
            {
                if (b < c) return b;
                return a > c ? a : c;
            }

            if (a <= b) return a;
            if (a < c) return a;
            return b > c ? b : c;
        }
    }
}