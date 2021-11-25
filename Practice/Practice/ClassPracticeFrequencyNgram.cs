using System;
using System.Collections.Generic;

namespace Practice
{
    public class ClassPracticeFrequencyNgram
    {
        public static Dictionary<string, int> MethodPracticeFrequencyNgram(string text)
        {
            var dictionary = new Dictionary<string, int>();
            var dictionary2 = new Dictionary<string, string>();
            var dictionary3 = new Dictionary<string, int>();
            var dictionary4 = new Dictionary<string, string>();
            var parsText = text.Split(' ', '.');
            var newText = new List<string>();

            //добавил в Лист
            for (int i = 0; i < parsText.Length; i++)
            {
                if (parsText[i] != "")
                    newText.Add(parsText[i]);
            }

            //добавить все варианты в словарь
            for (int i = 0; i < newText.Count; i++)
            {
                if (i == newText.Count - 1)
                    dictionary2[newText[i]] = ""; //обработка последей буквы в листе

                if (!dictionary2.ContainsKey(newText[i]))
                {
                    dictionary2[newText[i]] = newText[i + 1]; //присвоение ключу = [значение массива] + 1
                }

                else  //todo подсчет частоты пары ключ-значение
                {
                    /* если value = newText[i + 1]
                     * и встречается 1 раз, то string.CompareOrdinal
                     * если встречается > 1 раз, то выбираем более частотный
                     */

                    foreach (var kvp in dictionary2)
                    {
                        if (kvp.Value == "")
                        {

                        }
                    }

                    //подсчет частоты повторяющейся ОДНОЙ буквы,
                    if (!dictionary4.ContainsKey(newText[i]))
                    {
                        dictionary4[newText[i]] = newText[i + 1];
                    }

                    var x = 0;
                    var a = dictionary2[newText[i + 1]]; //dictionary2[newText[i + 1]];
                    var b = dictionary4[newText[i + 1]];
                    x = string.CompareOrdinal(a, b);
                    if (x < 0) Console.WriteLine("less than");
                    if (x > 0) Console.WriteLine("greater than");



                    //подсчет частоты повторяющейся ОДНОЙ буквы,
                    if (!dictionary3.ContainsKey(newText[i]))
                    {
                        dictionary3[newText[i]] = 0;
                    }
                    else dictionary3[newText[i]]++;
                }

                //todo если частота одинаковая, то выбрать лексикографичесое сравнение

                //ВТОРОЙ ВАРИАНТ
                var dist = new Dictionary<string, Dictionary<string, int>>(); // Создание такого словаря
                dist["first"] = new Dictionary<string, int>(); // Создание словаря для значения first
                dist["first"]["w"] = 1;  // Присваивание 
                dist["first"]["e"] = 2;  // значений

                Console.WriteLine(dist["first"]["e"]);

                //ТРЕТИЙ ВАРИАНТ
                /* Засунуть в Dictionary<string, string> все комбинации би и триограм
                *  В Dictionary<string, int> подсчитать кол-во частоты повторений
                */

            }


            ////подсчет частоты ОДНОЙ буквы
            //foreach (var a in newText)
            //{
            //    if (!dictionary.ContainsKey(a))
            //    {
            //        dictionary[a] = 0;
            //    }

            //    else dictionary[a]++;
            //}

            return dictionary;
        }
    }
}