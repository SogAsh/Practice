using System;

namespace Practice
{
    public class FixRecursion
    {
        // var items = new[] { 'a', 'b', 'c' };
        public static void WriteReversed(char[] items, int startIndex = 0)
        {
            if (startIndex == items.Length)
                return;
            WriteReversed(items, startIndex + 1);
            Console.Write(items[startIndex]); 
        }
    }
}
