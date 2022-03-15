using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public static class AverageOfThree
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
                if (a > c) return a;
                else return c;
            }
            if (a <= b) return a;
            if (a < c) return a;
            else return b > c ? b : c;
        }

        /*
         * 	Console.WriteLine(MiddleOfThree(2, 5, 4));
	        Console.WriteLine(MiddleOfThree(3, 1, 2));
	        Console.WriteLine(MiddleOfThree(3, 5, 9));
	        Console.WriteLine(MiddleOfThree("B", "Z", "A"));
	        Console.WriteLine(MiddleOfThree(3.45, 2.67, 3.12))
         */
        public static IComparable MiddleOfThree(params IComparable[] array)
        {
            var a = (IComparable)array.GetValue(0);
            var b = (IComparable)array.GetValue(1);
            var c = (IComparable)array.GetValue(2);
            
            if (a.CompareTo(b) == -1) //a < b
            {
                if (b.CompareTo(c) == -1) //b < c
                    return b;
                if (a.CompareTo(c) == 1) //a > c
                    return a;
                else return c;
            }
            if (a.CompareTo(b) == -1 || a.CompareTo(b) == 0) //a <= b
                return a;
            if (a.CompareTo(c) == -1) //a < c
                return a;
            if (b.CompareTo(c) == 1)
                return b;
            else return c;
        }
    }
}
