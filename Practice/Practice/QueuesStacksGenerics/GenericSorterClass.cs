using System;

namespace Practice.QueuesStacksGenerics
{
    public static class GenericSorterClass
    {
        public static void Sort<T> (this T[] array) where T : IComparable 
        //<T> дженерик параметр определяемый из аргументов метода при его вызове (пример <int>)
        //this - extension методы
        {
            for (int i = array.Length - 1; i > 0; i--)
            for (int j = 1; j <= i; j++)
            {
                T element1 = array[j - 1];
                T element2 = array[j];
                
                if (element1.CompareTo(element2) < 0)
                {
                    T temaporary = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temaporary;
                }
            }
        }
    }

    public class Program1234567
    {
        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        
        static void Main1234567()
        {
            var intArray = new int[] { 1, 2, 3 };
            intArray.Sort(); //так можно вызвать Sort у intArray, потому что мы прописали this в параметрах метода Sort 
            
            GenericSorterClass.Sort<int>(new int[]{1, 2, 3});
            //GenericSorterClass<int>.Sort(new int[]{1, 2, 3}); //в слечае когда "where T : IComparable" приписан к классу
            
            //GenericSorterClass<Point>.Sort(new Point[]{ X=1, Y=2}); нельзя т.к. Point не реализует IComparable
        }
        
        //Уже не нужен
        public static void BumbleSortNEWMethodWithIComparer(Array array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            for (int j = 1; j <= i; j++)
            {
                object element1 = array.GetValue(j - 1);
                object element2 = array.GetValue(j);
                IComparable comparableElement1 = (IComparable)element1; //или element1 as IComparable
                if (comparableElement1.CompareTo(element2) < 0)
                {
                    object temaporary = array.GetValue(j);
                    array.SetValue(array.GetValue(j - 1), j);
                    array.SetValue(temaporary, j - 1);
                }
            }
        }
    }
}