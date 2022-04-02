using System;
using System.Threading;

namespace Practice.QueuesStacksGenerics
{
    public class InputedInt
    {
        public bool Received { get; set; }
        public int Value;
    }
    
    public class GetNumberClass3
    {
        public static InputedInt TryGetNumber3()
        {
            var rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                if (Console.KeyAvailable)
                {
                    return new InputedInt
                    {
                        Value = rnd.Next(100),
                        Received = true
                    };
                }
                Thread.Sleep(100);
            }
            return new InputedInt
            {
                Received = false
            };
        }

        static void Main123456789()
        {
            var value = TryGetNumber3();

            if (value.Received)
                Console.WriteLine(value.Value);
            else
                Console.WriteLine("The server was unreachable");
        }
    }
}