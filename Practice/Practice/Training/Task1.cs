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
        public static Array CountElements()
        {
            var countElements = Console.ReadLine();

            var array = new int[int.Parse(countElements)];

            int elements;
            int coint = 0;

            for (int i = 0; i < array.Length; i++)
            {
                elements = int.Parse(Console.ReadLine());

                array[i] = elements;

                if (ChechEven(array[i]))
                    coint++;
            }

            var arr2 = new int[coint];

            for (int i = 0; i < array.Length; i++)
            {
                if (ChechEven(array[i]))
                    arr2[i] = array[i];
            }

            return array;
        }

        public static bool ChechEven(int a)
        {
            if (a % 2 == 0)
                return true;
            return false;
        }
    }
}