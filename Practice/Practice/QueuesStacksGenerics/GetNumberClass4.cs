using System;
using System.Threading;

namespace Practice.QueuesStacksGenerics
{
    public class GetNumberClass4
    {
        public static Tuple<bool, int> TryGetNumber3()
        {
            var rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                if (Console.KeyAvailable)
                {
                    return new Tuple<bool, int>(true, rnd.Next(100));
                }
                Thread.Sleep(100);
            }

            return Tuple.Create(false, 0); //= new Tuple<bool, int>(true, rnd.Next(100));
        }

        static void Main123456789()
        {
            var value = TryGetNumber3();

            if (value.Item1)
                Console.WriteLine(value.Item2);
            else
                Console.WriteLine("The server was unreachable");
        }
    }
}