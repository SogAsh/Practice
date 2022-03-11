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
            if (arrays == Array.Empty<Array>())
            {
                return null;
            }
            
            var elementType = arrays[0].GetType().GetElementType();
            Array result = null;
            int summaryLength = 0;

            if (ChekElementType(arrays, elementType, ref summaryLength)) return null;

            result = Array.CreateInstance(elementType, summaryLength); //summaryLength = 4

            int crossIndex = 0;

            PutValuesInNewArray(arrays, result, crossIndex);

            return result;
        }

        private static void PutValuesInNewArray(Array[] arrays, Array result, int crossIndex)
        {
            for (int i = 0; i < arrays.Length; i++)
            {
                for (int j = 0; j < arrays[i].Length; j++)
                {
                    var valueOfArray = arrays[i].GetValue(j);

                    result.SetValue(valueOfArray, crossIndex);
                    crossIndex = crossIndex + 1;
                }
            }
        }

        private static bool ChekElementType(Array[] arrays, Type elementType, ref int summaryLength)
        {
            for (int i = 0; i < arrays.Length; i++)
            {
                var nextElementType2 = arrays[i].GetType().GetElementType();

                if (elementType != nextElementType2)
                {
                    return true;
                }

                summaryLength = summaryLength + arrays[i].Length;
            }

            return false;
        }
    }
}