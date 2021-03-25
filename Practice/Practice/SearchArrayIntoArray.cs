using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class SearchArrayIntoArray
    {
        public static int FindSubarrayStartIndex(int[] array, int[] subArray)
        {
            for (var i = 0; i < array.Length - subArray.Length + 1; i++)
                if (ContainsAtIndex(array, subArray, i))
                    return i;
            return -1;
        }

        private static bool ContainsAtIndex(int[] array, int[] subArray, int i)
        {
            for (var j = 0; j < subArray.Length; j++)
            {
                if (array[i + j] != subArray[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}