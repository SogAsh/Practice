using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.yieldReturn
{
    public class GenerateSequences
    {
        public static IEnumerable<int> GenerateCycle(int maxValue)
        {
            int baseValue = 0;
            var currentValue = 0;
            if (baseValue == maxValue)
                yield return baseValue;
            yield return baseValue;

            while (true)
            {
                var nextValue = currentValue + 1;
                if (nextValue == maxValue)
                    nextValue = baseValue;
                yield return nextValue;
                currentValue = nextValue;
            }
        }

        public static void GenerateSequencesMain()
        {
            foreach (var number in GenerateCycle(4).Take(8))
            {
                Console.Write(number);
            }
        }
    }
}