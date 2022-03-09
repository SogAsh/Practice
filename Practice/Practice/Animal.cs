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
            size = "wer";
            Console.WriteLine("PrintExtensions() name " + name);
            Console.WriteLine("PrintExtensions() age " + age);
            Console.WriteLine("PrintExtensions() size " + size);
        }

    }
}