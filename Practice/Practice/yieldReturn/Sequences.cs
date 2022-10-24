using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Practice.yieldReturn
{
    public class Sequences
    {
        public static IEnumerable<int> Fibonaci
        {
            get { return new FibonaciSeqquence(); }  //апкаст к IEnumerable<T>, т.к. List<int> реализует IEnumerable<T>
        }
    }

    public class FibonaciSeqquence : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            int previous = 1;
            int current = 1;
            yield return 1;
            yield return 1;
            while (true)
            {
                var newValue = current + previous;
                previous = current;
                current = newValue;
                yield return current;

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    

    public class Program12345678
    {
        public static void Main12345678()
        {
            foreach (var e in Sequences.Fibonaci)
            {
                Console.Write(e);
            }
        }
    }
}