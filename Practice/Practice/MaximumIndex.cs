using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class MaximumIndex
    {
        /*
         * Если в массиве максимальный элемент встречается несколько раз,
         * вывести нужно минимальный индекс.
           Если массив пуст, вывести нужно -1.
         */
        public static double Min(double[] array)
        {
            var min = double.MaxValue;
            foreach (var item in array)
                if (item < min)
                    min = item;
            return min;
        }

        public static int MaxIndex(double[] array)
        {
            //double[] a = {1, 9, 9, 8, 9, 2, 2};
            //double[] b = {1, 2, 46, 14, 64, 64};

            double max = 0;
            if (array == null) return -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
                else if (array[i] == array[i-1]) max = array[i-1];
            }

            return (int)Math.Round(max);
        }
    }
}