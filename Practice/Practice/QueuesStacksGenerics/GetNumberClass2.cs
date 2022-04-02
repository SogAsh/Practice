using System;
using System.Threading;

namespace Practice.QueuesStacksGenerics
{
    public class GetNumberClass2
    {
        public static bool TryGetNumber2(out int inputedNumber) //out значит что мы должны присвоить значение переменной inputedNumber
        {
            var rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                if (Console.KeyAvailable)
                {
                    inputedNumber = rnd.Next(100);
                    return true;
                }
                Thread.Sleep(100);
            }
            inputedNumber = 0;
            return false;
        }

        static void Main123456789()
        {
            int inputedNumber;

            if (TryGetNumber2(out inputedNumber))
                Console.WriteLine(inputedNumber);
            else
                Console.WriteLine("The server was unreachable");
        }
    }
}