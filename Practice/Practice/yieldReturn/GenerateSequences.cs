using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.yieldReturn
{
    public class GenerateSequences
    {
        public static IEnumerable<int> GenerateCycle(int maxValue)
        {
            while (true)
            {
                var newValue = current + previous;
                previous = current;
                current = newValue;
                yield return current;
        
            }
        }

        public static void GenerateSequencesMain(string[] args)
        {
            foreach (var number in GenerateCycle(4).Take(8))
            {
                Console.WriteLine(number);
            }
        }
    }
}