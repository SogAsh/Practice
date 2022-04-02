using System;
using System.Threading;

namespace Practice.QueuesStacksGenerics
{
    public class GetNumberClass
    {
        public static int TryGetNumber()
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
            Console.WriteLine(TryGetNumber());
        }
    }
}