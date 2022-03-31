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
        public static double Min(double[] array) //метод поиска минимума в массиве
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
        public static object MinGeneral(Array array) //метод поиска минимума в массиве для общего случая
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
            // double[] a = { 1, 9, 9, 8, 9, 2, 2 };
            // double[] b = { 1, 2, 46, 14, 64, 64 };
            // double[] d = { 1, 2, 3 };

            var maxValue = double.MinValue;
            var maxIndex = -1;
            for (var i = 0; i < array.Length; i++)
            {
                if (!(maxValue < array[i])) 
                    continue;
                maxValue = array[i]; //если continue;, то строка не читается
                maxIndex = i; //если continue;, то строка не читается
            }
            return maxIndex;
        }
        
        public static object MaxGeneral(Array array)
        {
            if (array.Length == 0) return -1;
            var max = (IComparable)array.GetValue(array.Length - 1);
            
            for (int i = array.Length - 1; i > 0; i--)
            {
                var obj1 = (IComparable)array.GetValue(i); 
                var obj2 = (IComparable)array.GetValue(i-1); 
                
                if (obj1.CompareTo(obj2) > 0)
                {
                    max = obj1;
                }

                max = obj2;
            }

            return max;
        }
        
        //MaxIndexGeneral см. тут QueuesStacksGenerics - MaxIndexGeneral
    }
}