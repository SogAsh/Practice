using System;

namespace Practice.QueuesStacksGenerics
{
    public class MaxIndexGeneral
    {
        public static T Max<T> (T[] source) where T : IComparable
        {
            // if (source.Length == 0) return -1;
            var max = source.Length - 1;

            for (int i = source.Length - 1; i > 0; i--)
            {
                T obj1 = source[i];
                T obj2 = source[i - 1];

                if (obj1.CompareTo(obj2) > 0)
                {
                    max = obj1;
                }

                max = obj2;
            }

            return max;
        }


        public static object MaxGeneral(Array array)
        {
            if (array.Length == 0) return -1;
            var max = (IComparable)array.GetValue(array.Length - 1);

            for (int i = array.Length - 1; i > 0; i--)
            {
                var obj1 = (IComparable)array.GetValue(i);
                var obj2 = (IComparable)array.GetValue(i - 1);

                if (obj1.CompareTo(obj2) > 0)
                {
                    max = obj1;
                }

                max = obj2;
            }

            return max;
        }
    }
}