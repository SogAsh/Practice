using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Virtual2 : Virtual //Уроки C# (C sharp) | #20 - Виртуальные методы
    {
        private int keys = 10;

        public override void Print()
        {
            base.Print(); //вызвать все что в оригинальном Print()
            Console.WriteLine("New overrided value");
        }
    }
}
