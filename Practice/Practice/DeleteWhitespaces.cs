using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class DeleteWhitespaces
    {
        /*
            Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces("a"));
            Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces(" b"));
            Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces(" cd"));
            Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces(" efg"));
            Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces(" text"));
            Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces(" two words"));
            Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces("  two spaces"));
            Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces("	tabs"));
            Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces("		two	tabs"));
            Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces("                             many spaces"));
            Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces("               "));
            Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces("\n\r line breaks are spaces too"));
         */
        public static string RemoveStartSpaces(string text)
        {
            var i = 0;
            while (text != "")
            {

                while (char.IsWhiteSpace(text[i]))
                {
                    text = text.Substring(i + 1);
                    if (text == "") break;
                }
                return text;
            }
            return "";
        }
    }
}
