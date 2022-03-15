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
        
        /*
         *  Console.WriteLine(AverageOfThree.Min(new[] { 3, 6, 2, 4 }));
            Console.WriteLine(AverageOfThree.Min(new[] { "B", "A", "C", "D" }));
            Console.WriteLine(AverageOfThree.Min(new[] { '4', '2', 
         */
        public static object Min(Array array)
        {
            var min = (IComparable)array.GetValue(array.Length - 1);
            
            for (int i = array.Length - 1; i > 0; i--)
            {
                var obj1 = (IComparable)array.GetValue(i);
                var obj2 = (IComparable)array.GetValue(i-1);
                
                if (obj1.CompareTo(obj2) < 0)
                {
                    min = obj1;
                }
            }

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
                if (array[i] > max) 
                    max = array[i];
                else if (array[i] == array[i-1]) 
                    max = array[i-1];
            }

            return (int)Math.Round(max);
        }
    }
}