using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.yieldReturn
{
    public class ZipSum
    {
        private static IEnumerable<int> ZipSumMethod(IEnumerable<int> first, IEnumerable<int> second)
        {
            var e1 = first.GetEnumerator();
            var e2 = second.GetEnumerator();
            while(e1.MoveNext())
            {
                e2.MoveNext();
                yield return e1.Current + e2.Current;
            }
        }
     
        public static void ZipSumMain()
        {
            Console.WriteLine(string.Join(" ", ZipSumMethod(new[] { 1 }, new[] { 0 })));
            Console.WriteLine(string.Join(" ", ZipSumMethod(new[] { 1, 2 }, new[] { 1, 2 })));
            Console.WriteLine(string.Join(" ", ZipSumMethod(new int[0], new int[0])));
            Console.WriteLine(string.Join(" ", ZipSumMethod(new[] { 1, 3, 5 }, new[] { 5, 3, -1 })));
        }
    }
}