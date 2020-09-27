using System;

namespace Practice2
{
    public class Cat : Animal
    {
        public static void MethodCat()
        {
            Animal cat = new Animal();
            cat.name = "Barsik";

            Console.WriteLine(cat.name);
        }
    }
}