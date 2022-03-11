using System;
using System.Collections.Generic;

namespace Practice.Inheritance
{
    public class CombineClass
    {
        /*
            var ints = new[] { 1, 2 };
            var strings = new[] { "A", "B" };
          
            CombineClass.Print(Combine(ints, ints));
            CombineClass.Print(Combine(ints, ints, ints));
            CombineClass.Print(Combine(ints));
            CombineClass.Print(Combine());
            CombineClass.Print(Combine(strings, strings));
            CombineClass.Print(Combine(ints, strings));
         */
        public static void Print(Array array)
        {
            if (array == null)
            {
                Console.WriteLine("null");
                return;
            }

            for (int i = 0; i < array.Length; i++)
                Console.Write("{0} ", array.GetValue(i));
            Console.WriteLine();
        }

        public static Array Combine(params Array[] arrays)
        {
            var elementType = arrays[0].GetType().GetElementType();
            Array result = null;
            int summaryLength = 0;

            for (int i = 0; i < arrays.Length; i++)
            {
                var elementType2 = arrays[i].GetType().GetElementType();

                if (elementType != elementType2)
                {
                    return null;
                }

                summaryLength = summaryLength + arrays[i].Length;
            }

            result = Array.CreateInstance(elementType, summaryLength); //summaryLength = 4

            int rrr = 0;

            for (int i = 0; i < arrays.Length; i++)
            {
                var temp = arrays[i];

                for (int j = 0; j < arrays.Length; j++)
                {
                    var fgfgee = temp.GetValue(j);

                    result.SetValue(fgfgee, rrr);
                    rrr = rrr + 1;
                }
            }

            return result;
        }
    }
}