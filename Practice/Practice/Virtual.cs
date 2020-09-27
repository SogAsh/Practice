using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Virtual //Уроки C# (C sharp) | #20 - Виртуальные методы
    {
        private int keys = 10;
        public virtual void Print()
        {
            Console.WriteLine("Old overrided value " + keys);
        }
    }
}
