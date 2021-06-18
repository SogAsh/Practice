using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class MethodsWanted
    {
        /*
         * Console.WriteLine(MethodsWanted.GetLastHalf("I love CSharp!"));
           Console.WriteLine(MethodsWanted.GetLastHalf("1234567890"));
           Console.WriteLine(MethodsWanted.GetLastHalf("до ре ми фа соль ля си"));
         */
        public static string GetLastHalf(string text)
        {
            var count = text.Length / 2;
            var halfWord = text.Substring(0, count); //"I love "
            string [] wordWithoutWhitespace = halfWord.Split(' '); // [0]="I", [1]="love", [2]="",
            string resultWord = string.Join("", wordWithoutWhitespace);

            return resultWord;
        }
    }
}
