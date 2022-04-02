using System;
using System.Threading;

namespace Practice.QueuesStacksGenerics
{
    public class GetNumberClass5
    {
        public static int? TryGetNumber3()
        {
            var rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                if (Console.KeyAvailable)
                {
                    return rnd.Next(100);
                }
                Thread.Sleep(100);
            }

            return null;
        }

        static void Main123456789()
        {
            var value = TryGetNumber3();

            if (value!=null)
                Console.WriteLine(value);
            else
                Console.WriteLine("The server was unreachable");
        }
    }
}