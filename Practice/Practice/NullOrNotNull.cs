using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class NullOrNotNull
    {
        /*
         *  Console.WriteLine(NullOrNotNull.CheckFirstElement(null));
            Console.WriteLine(NullOrNotNull.CheckFirstElement(new int[0]));
            Console.WriteLine(NullOrNotNull.CheckFirstElement(new[] { 1 }));
            Console.WriteLine(NullOrNotNull.CheckFirstElement(new[] { 0 }));
         */
        public static bool CheckFirstElement(int[] array)
        {
            if (array != null) //if null => false
            {
                if (array.Length != 0) //if .Lenth > 0 => false
                {
                    if (array[0] == 0)
                        return true;
                }
            }

            return false;
        }
    }
}