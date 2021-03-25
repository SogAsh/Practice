using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class MethodsWanted
    {
        public static string GetLastHalf(string text)
        {
            var count = text.Length / 2;
            var halfWord = text.Substring(0, count);
            string [] wordWithoutWhitespace = halfWord.Split(' ');
            string resultWord = string.Join("", wordWithoutWhitespace);

            return resultWord;
        }
    }
}
