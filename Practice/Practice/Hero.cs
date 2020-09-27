using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Hero //Уроки C# (C sharp) | #19 - Операторы is и as. Массив указателей
    {
        public string Name { get; set; }
        public string Mark { get; set; }
        protected int Age { get; set; } //можно использовать только в унаследованном Reno

        public Hero(string name) //этот конструктор нужен для конструктора Reno, для этого использую "base(name)"
        {
            Name = name;
        }
    }
}
