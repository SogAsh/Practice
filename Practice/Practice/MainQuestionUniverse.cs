using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class MainQuestionUniverse
    {
        //PrintExtensions(GetSquare(42)) Он желает знать квадрат этого числа
        public static double GetSquare(int a)
        {
            var b = Math.Pow(a, 2);
            return b;
        }

        public static void NewPrint(double c)
        {
            Console.WriteLine(c);
        }
    }
}
