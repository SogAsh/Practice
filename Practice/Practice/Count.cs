using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Count
    {
        //int[] a = { 1, 2, 1, 1 };
        public static int GetElementCount(int[] items, int itemToCount)
        {
            var index = 0;

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == itemToCount)
                    index++;
            }

            return index;
        }
    }
}