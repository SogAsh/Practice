using System;
using System.Collections.Generic;

namespace Practice.yieldReturn
{
    public class Sequences
    {
        public static IEnumerable<int> Fibonaci
        {
            get
            {
                int previous = 1;
                int current = 1;
                yield return 1;
                yield return 1;
                while (true)
                {
                    var newValue = current + previous;
                    previous = current;
                    current = newValue;
                    yield return current;
                }

                ;
            }
        }
    }

    public class Program12345678
    {
        public static void Main12345678()
        {
            foreach (var e in Sequences.Fibonaci)
            {
                Console.Write(e);
            }
        }
    }
}