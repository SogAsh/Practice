using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class AverageOfThree
    {
        /*
            Console.WriteLine(AverageOfThree.MiddleOf(5, 0, 100)); // => 5
            Console.WriteLine(AverageOfThree.MiddleOf(12, 12, 11)); // => 12
            Console.WriteLine(AverageOfThree.MiddleOf(1, 1, 1)); // => 1
            Console.WriteLine(AverageOfThree.MiddleOf(2, 3, 2)); //2
            Console.WriteLine(AverageOfThree.MiddleOf(8, 8, 8)); //8
            Console.WriteLine(AverageOfThree.MiddleOf(5, 0, 1)); //1
            Console.WriteLine(AverageOfThree.MiddleOf(47, 15, 19)); //19
            Console.WriteLine(AverageOfThree.MiddleOf(11, 97, 97)); //97
         */
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
