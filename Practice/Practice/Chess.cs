using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Chess
    {
        /*
         *  WriteBoard(8);
	        WriteBoard(1);
	        WriteBoard(2);
	        WriteBoard(3);
	        WriteBoard(10);
         */
        public static void WriteBoard(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i % 2 == 1)
                        Console.Write(j % 2 == 1 ? "#" : ".");
                    else
                    if (j % 2 == 1) Console.Write(".");
                    else Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}