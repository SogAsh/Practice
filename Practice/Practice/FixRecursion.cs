using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class FixRecursion
    {
        public static void WriteReversed(char[] items, int startIndex = 0)
        {
            // Выводим в обратном порядке все элементы с индексом больше startIndex
            for (int i = startIndex + 1; i < items.Length; i++)
            {
                Console.Write(items[i] + " ");

                WriteReversed(items, i);
            }

            //WriteReversed(items, startIndex + 1);

            // а потом выводим сам элемент startIndex
            Console.Write(items[startIndex]);
        }
    }
}
