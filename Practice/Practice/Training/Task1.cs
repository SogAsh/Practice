using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Training
{
    /*
     * Запрос ввод кол-ва массива
     * Сами элементы
     * Выход новый массив, с четными элементами массива
     * Поменять местами макс и мин
     */
    public class Task1
    {
        public static void CountElements()
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
                Console.WriteLine("Элемент массива: " + resultArray[i]);
            }

            var finishArray = SwapMaxMin(resultArray);

            //for (int i = 0; i < finishArray.Length; i++)
            //{
            //    Console.WriteLine("Элемент массива: " + finishArray[i]);
            //}
        }

        public static bool ChechEven(int a)
        {
            if (a % 2 == 0)
                return true;
            return false;
        }

        public static int[] SwapMaxMin(int[] array)
        {
            var min = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }

            return array;
        }
    }
}