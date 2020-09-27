using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class ForInterface : IShop, IBook //Уроки C# (C sharp) | #22 - Интерфейсы
    {
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("Some Interface text");
        }

        public void PrintBook()
        {
            Console.WriteLine("Some Interface book");
        }
    }
}
