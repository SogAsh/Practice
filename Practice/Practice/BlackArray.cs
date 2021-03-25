using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class BlackArray
    {
        public static int[] GetFirstEvenNumbers(int count)
        {
            int[] array = new int[count];
            for (int i = 1; i <= count; i++)
            {
                array[i - 1] = i * 2;
            }
            return array;
        }
    }
}