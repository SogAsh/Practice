using System;

namespace Practice.Inheritance
{
    public static class PrintClass
    {
        public static void PrintExtensions(params object[] arguments)
        {
            for(var i=0; i<arguments.Length; i++)
            {
                if (i > 0) 
                    Console.Write(", ");
                Console.Write(arguments.GetValue(i));
            }
            Console.WriteLine();
        }
    }
}