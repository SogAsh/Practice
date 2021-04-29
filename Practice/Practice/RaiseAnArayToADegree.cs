using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class RaiseAnArayToADegree
    {
        /*
         *  var arrayToPower = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
         
            RaiseAnArayToADegree.PrintArray(RaiseAnArayToADegree.GetPoweredArray(arrayToPower, 1));

            если вы будете менять исходный массив, то следующие два теста сработают неверно:
            RaiseAnArayToADegree.PrintArray(RaiseAnArayToADegree.GetPoweredArray(arrayToPower, 2));
            RaiseAnArayToADegree.PrintArray(RaiseAnArayToADegree.GetPoweredArray(arrayToPower, 3));

            не забывайте про частные случаи:
            RaiseAnArayToADegree.PrintArray(RaiseAnArayToADegree.GetPoweredArray(new int[0], 1)); //1
            RaiseAnArayToADegree.PrintArray(RaiseAnArayToADegree.GetPoweredArray(new[] { 42 }, 0)); //пусто
         */
        public static int[] GetPoweredArray(int[] arr, int power)
        {
            int[] array = new int[arr.Length];
            arr.CopyTo(array, 0);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int) Math.Pow(array[i], power);
            }

            return array;
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + "{0}", i < arr.Length - 1 ? " " : "");
            Console.WriteLine("");
        }
    }
}