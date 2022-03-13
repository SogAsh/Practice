using System;

namespace Practice
{
    public class BumbleSort
    {
        public static void NewMain1()
        {
            var intArray = new int[] {1, 3, 2};
            var stringArray = new string[] {"B", "A", "C"};
            //Array array = (Array) intArray; //апкаст

            ProcessArray(intArray);
            ProcessArray(stringArray);

            intArray.Swap(0, 1); //или ArrayExtensions.Swap(intArray, 0, 1);
            stringArray.Swap(0, 1); //или ArrayExtensions.Swap(stringArray, 0, 1);

            intArray.BumbleSortNEWMethod();
            stringArray.BumbleSortNEWMethod();
        }

        public static void ProcessArray(Array array)
        {
            object obj = array.GetValue(0); //апкаст к object
            Console.WriteLine(obj);
        }

        public static void BumbleSortNEWMethod(this Array array) //сортирует любые массивы
        {
            for (int i = array.Length - 1; i > 0; i--)
                for (int j = 1; j <= i; j++)
                {
                    var element1 = (IComparable) array.GetValue(j); //object даункастим к IComparable
                    var element0 = (IComparable) array.GetValue(j - 1);
                    if (element1.CompareTo(element0) < 0)
                    {
                        array.Swap(j-1, j);
                    }
                }
        }


        public static void BumbleSortOLDMethod(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            for (int j = 1; j <= i; j++)
                if (array[j] < array[j - 1])
                {
                    var temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                }
        }
    }

    public static class ArrayExtensions
    {
        public static void Swap(this Array array, int i, int j)
        {
            object obj = array.GetValue(i);
            array.SetValue(array.GetValue(j), i); //jое засовываем в iое
            array.SetValue(obj, j); //iое засовываем в jое
        }
    }
}