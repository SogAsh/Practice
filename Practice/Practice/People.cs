﻿using System;

namespace Practice
{
    public class People //Уроки C# (C sharp) | #15 - Конструкторы, а также static
    {
        public string last_name; //для констуктора по умолчанию

        public string name;
        public int age;

        public People() //конструктор по умолчанию не должен иметь параметров на вход
        {
            name = "Brad";
            age = 18;

            Print();
        }

        public People(string name, int age) //конструктор. При инициализации объекта класса мы сразу можем
        {
            this.name = name; //Уроки C# (C sharp) | #16 - Указатель this
            this.age = age;

            Print();
        }

        public void Print()
        {
            Console.WriteLine("PrintExtensions() name " + name);
            Console.WriteLine("PrintExtensions() age " + age);
        }
}
}