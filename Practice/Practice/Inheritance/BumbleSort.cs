using System;
using System.Collections;
using Practice.OOP;

namespace Practice
{
    class Pont : IComparable
    {
        public int X;
        public int Y;
        public int CompareTo(object obj)
        {
            var point = (Point)obj; //даункаст 
            var thisDistance = Math.Sqrt(X * X + Y * Y);
            var thatDistance = Math.Sqrt(point.X * point.X + point.Y * point.Y);
            
            return thisDistance.CompareTo(thatDistance);
        }
    }

    class DistanceToZeroComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            double DistanceToZero(Point point)
            {
                return Math.Sqrt(point.X * point.X + point.Y * point.Y);
            }
            
            var point1 = (Point)x;
            var point2 = (Point)y;
            return DistanceToZero(point1).CompareTo(point2);
        }
    }
    
    public static class BumbleSort
    {
        public static void MakeBumbleSortMethod_WithNewMethod()
        {
            var intArray = new int[] {1, 3, 2};
            var stringArray = new string[] {"B", "A", "C"};
            Array array = (Array) intArray; //апкаст

            ProcessArray(intArray);
            ProcessArray(stringArray);

            intArray.Swap(0, 1); //или ArrayExtensions.Swap(intArray, 0, 1);
            stringArray.Swap(0, 1); //или ArrayExtensions.Swap(stringArray, 0, 1);

            var pointArray = new Point[]
            {
                new Point { X = 1, Y = 1 },
                new Point { X = 3, Y = 3 },
                new Point { X = 2, Y = 2 }
            };
            //pointArray.BumbleSortNEWMethod(); //метод BumbleSortNEWMethod не должен быть у массива pointArray
                                            //т.к. класс Point не реализует интерфейс IComparable
                                            //но в итоге используем BumbleSortNEWMethodWithIComparer
            intArray.BumbleSortNEWMethod();
            stringArray.BumbleSortNEWMethod();
            
            pointArray.BumbleSortNEWNEWMethodWithIComparer(new DistanceToZeroComparer());
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
                    var element1 = (IComparable)array.GetValue(j); //object даункастим к IComparable
                    var element0 = (IComparable)array.GetValue(j - 1);
                    if (element1.CompareTo(element0) < 0)
                    {
                        array.Swap(j-1, j);
                    }
                }
        }
        /* 
         *  A CompareTo B = -1, т.е. A < B
         *  A CompareTo B = +1, т.е. A > B
         *  A CompareTo B = 0, т.е. B = A
         */ 
        
        public static void BumbleSortNEWNEWMethodWithIComparer(this Array array, IComparer comparer) //сортирует любые массивы
        {
            for (int i = array.Length - 1; i > 0; i--)
            for (int j = 1; j <= i; j++)
            {
                var element0 = array.GetValue(j - 1);
                var element1 = array.GetValue(j); //object даункастим к IComparable
                if (comparer.Compare(element1, element0) < 0)
                {
                    array.Swap(j-1, j);
                }
            }
        }
        
        //Дженерики и сортировка массивов https://ulearn.me/course/basicprogramming2/Dzheneriki_i_sortirovka_massivov_93320c13-9170-4e84-8602-d4fa3bffb0f7
        public static void BumbleSortNEWMethodWithIComparer(Array array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            for (int j = 1; j <= i; j++)
            {
                object element1 = array.GetValue(j - 1);
                object element2 = array.GetValue(j); 
                IComparable comparableElement1 = element1 as IComparable;
                if (comparableElement1.CompareTo(element2) < 0)
                {
                    object temaporary = array.GetValue(j);
                    array.SetValue(array.GetValue(j - 1), j);
                    array.SetValue(temaporary, j - 1);
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