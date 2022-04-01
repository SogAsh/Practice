using System;

namespace Practice.QueuesStacksGenerics
{
    public class MaxIndexGeneralClass
    {
        public static T MaxGeneralMethod<T> (T[] source) where T : IComparable
        {
            if (source.Length == 0) 
                return default(T); 
            
            T max = source[source.Length - 1];

            for (int i = source.Length - 1; i > 0; i--)
            {
                T obj1 = source[i];
                T obj2 = source[i - 1];

                if (obj1.CompareTo(obj2) > 0)
                {
                    if (max.CompareTo(obj1) > 0)
                    {
                        continue;
                    }
                    else
                        max = obj1;
                }
                else
                    max = obj2;
            }

            return max;
        }
    }
}