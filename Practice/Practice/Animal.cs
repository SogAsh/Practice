using System;

namespace Practice
{
    public class Animal
    {
        public string name = "Baron";
        public int age = 1;
        protected string size;
        public static int count = 0;

        public void Print()
        {
            Console.WriteLine("Print() name " + name);
            Console.WriteLine("Print() age " + age);
            Console.WriteLine("Print() size " + size);
        }

    }
}