using System;

namespace Practice.Inheritance
{
    public class CopyToTest
    {
        public static void PrintValues()
        {
            Array mySourceArray = Array.CreateInstance(typeof(string), 6);
            mySourceArray.SetValue("three", 0);
            mySourceArray.SetValue("napping", 1);
            mySourceArray.SetValue("cats", 2);
            mySourceArray.SetValue("in", 3);
            mySourceArray.SetValue("the", 4);
            mySourceArray.SetValue("barn", 5);

            Array myTargetArray = Array.CreateInstance(typeof(string), 12);
            myTargetArray.SetValue("The", 0);
            myTargetArray.SetValue("quick", 1);
            myTargetArray.SetValue("brown", 2);
            myTargetArray.SetValue("fox", 3);
            myTargetArray.SetValue("jumps", 4);
            myTargetArray.SetValue("over", 5);

            mySourceArray.CopyTo(myTargetArray, 6);

            foreach (var VARIABLE in myTargetArray)
            {
                Console.WriteLine(VARIABLE + " ");
            }
        }

        public static void PrintValues2()
        {
            var myTargetArray = new[] { 1, 2 };
            var mySourceArray = new[] { 3, 4 };
            
            Array result = Array.CreateInstance(typeof(int), 4);
            
            mySourceArray.CopyTo(result, 0); //с какого индекса должен въезжать масив mySourceArray в массив result
            
            foreach (var VARIABLE in result)
            {
                Console.WriteLine(VARIABLE + " ");
            }

        }
    }
}