using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class MarvelHero : Hero //Уроки C# (C sharp) | #19 - Операторы is и as. Массив указателей
    {
        public void Method() //метод, использую унаследованную переменную Age
        {
            Age = 18;
            Console.WriteLine("Method() - Age" + Age);
        }

        private string sex;
        public MarvelHero(string name, string sex) : base(name) //конструктор
        {
            this.sex = sex;
            Console.WriteLine("Constructor MarvelHero - sex = " + sex);
            Console.WriteLine("Constructor MarvelHero - name = " + name);
        }
    }
}
