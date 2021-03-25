using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class DeleteWhitespaces
    {
        public static string RemoveStartSpaces(string text)
        {
            if (text == null) return null;
            if (string.IsNullOrWhiteSpace(text)) return string.Empty;
            if (!char.IsWhiteSpace(text[0])) return text;
            var number = 0;
            while (char.IsWhiteSpace(text[number]))
                number++;
            return text.Substring(number);
        }
    }
}