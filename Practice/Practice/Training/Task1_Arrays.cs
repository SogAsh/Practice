using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Training
{
    /*
     * Запрос вводd длины массива
     * Запрос самих элементов
     * На выходе новый массив, с четными элементами массива
     * Поменять местами макс и мин значения
     */
    public class Task1
    {
        public static int[] CountElements()
        {
            Console.WriteLine("Введите длину масива");
            var countElements = Console.ReadLine();

            var array = new int[int.Parse(countElements)];

            int elements;
            int coint = 0;
            int cointForResultArray = 0;


            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите элемент масива");
                elements = int.Parse(Console.ReadLine());

                array[i] = elements;

                if (ChechEven(array[i]))
                    coint++;
            }

            var resultArray = new int[coint];

            for (int i = 0; i < array.Length; i++)
            {
                if (ChechEven(array[i]))
                {
                    resultArray[cointForResultArray] = array[i];
                    cointForResultArray++;
                }
            }

            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.WriteLine("Четный элемент массива: " + resultArray[i]);
            }

            var finishArray = SwapMaxMin(resultArray);
            
            for (int i = 0; i < finishArray.Length; i++)
            {
                Console.WriteLine("Элемент сменил местами: " + finishArray[i]);
            }
            return finishArray;
        }

        public static bool ChechEven(int a)
        {
            if (a % 2 == 0)
                return true;
            return false;
        }

        public static int[] SwapMaxMin(int[] array) //4, 2 
        {
            var min = array[0];
            var max = array[0];
            var minI = 0;
            var maxI = 0;
            
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minI = i;
                }

                else if (array[i] > max)
                {
                    max = array[i];
                    maxI = i;
                }
            }

            array[minI] = max;
            array[maxI] = min;

            return array;
        }
        
        // public static void Swap(Array array, int i, int j)
        // {
        //     object obj = array.GetValue(i);
        //     array.SetValue(array.GetValue(j), i); //jое засовываем в iое
        //     array.SetValue(obj, j); //iое засовываем в jое
        // }
    }
}