using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class MaximumIndex
    {
        public static int MaxIndex(double[] array)
        {
            var maxValue = double.MinValue;
            var maxIndex = -1;

            for (var i = 0; i < array.Length; i++)
            {
                if (!(maxValue < array[i])) continue;
                maxValue = array[i];
                maxIndex = i;
            }

            return maxIndex;
        }
    }
}