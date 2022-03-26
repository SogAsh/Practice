using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class BlackArray
    {
        public static int[] GetFirstEvenNumbers(int count) //3
        {
            int[] array = new int[count];
            int b = 0;
            int c = 0;

            for (int i = 0; i < array.Length; i++) //0 1 2
            {
                if (i % 2 == 0) 
                    b = array[i] = c + 2; //2
                
                else c = array[i] = b + 2; //6

                Console.WriteLine(array[i]);
            }
            
            return array;
        }
    }
}
