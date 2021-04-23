using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Frame
    {
        /*
            +-------------+
            | Hello world |
            +-------------+

            WriteTextWithBorder("Menu:");
	        WriteTextWithBorder("");
	        WriteTextWithBorder(" ");
	        WriteTextWithBorder("Game Over!");
	        WriteTextWithBorder("Select level:");
         */
        public static void WriteTextWithBorder(string text)
        {
            WriteBorder(text);
            Console.WriteLine("| " + text + " |");
            WriteBorder(text);
        }

        public static void WriteBorder(string text)
        {
            Console.Write("+-");
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("-+");
        }
    }
}
