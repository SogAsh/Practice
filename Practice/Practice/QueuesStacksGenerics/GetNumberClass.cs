using System;
using System.Threading;

namespace Practice.QueuesStacksGenerics
{
    public class GetNumberClass
    {
        public static int GetNumber1()
        {
            var rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                if (Console.KeyAvailable)
                    return rnd.Next(100);
                
                Thread.Sleep(100);
            }
            return -1;
        }
        
        static void Main12345678()
        {
            Console.WriteLine(GetNumber1());
            
            // var value = GetNumber1();
            // if (value == -1)
            //     
            //     Console.WriteLine("Error");
            // else
            //     Console.WriteLine(value);
        }
    }
}