﻿using System;
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
        public Reno(string sex, string name) : base(name) //конструктор. base значит что конструктор наследует конструктор из класса от которого наследуется Reno
                                                        //т.е. Cars
        {
            this.sex = sex;
            Console.WriteLine("Constructor Reno - sex = " + sex);
            Console.WriteLine("Constructor Reno - name = " + name);

        }



    }
}
