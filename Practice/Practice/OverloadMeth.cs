using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class OverloadMeth //Уроки C# (C sharp) | #23 - Перегрузка методов
    {
        public void Multiply(int a, int b)
        {
            Console.Write("Multiply result = " + a * b);
        }

        public void Multiply(int a, int b, int c) //Перегрузка методов
        {
            Console.Write("Overload Multiply result = " + a * b * c);
        }

        public void Multiply(string str) //Перегрузка методов
        {
            Console.Write("Overload Multiply result = " + str);
        }
    }
}
