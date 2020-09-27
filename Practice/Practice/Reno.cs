using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Reno : Cars //Уроки C# (C sharp) | #18 - Наследование
    {
        public void Method() //метод, использую унаследованную переменную Age
        {
            Age = 18;
            Console.WriteLine("Method() - Age" + Age);
        }

        private string sex;
        public Reno(string name, string sex) : base(name) //конструктор
        {
            this.sex = sex;
            Console.WriteLine("Constructor Reno - sex = " + sex);
            Console.WriteLine("Constructor Reno - name = " + name);

        }



    }
}
