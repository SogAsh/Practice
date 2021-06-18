using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class ReplaceSeparators
    {
        /*
         * Используйте метод Split у строки, чтобы разбить строку по известным разделителям.
         * Изучите документацию на string.Split, чтобы найти нужный набор параметров этой функции.
           Используйте перегрузку метода Split, которая принимает в качестве разделителей массив строк, 
           вместо массива символов.
           Для объединения строк через разделитель воспользуйтесь методом Join.
         */
        public static string ReplaceIncorrectSeparators(string text)
        {
            string [] delimiterChars = { " ", ",", ":", "-", ";"}; //'\n', ,  '\t' 

            string[] words = text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

            string resultWord;

            if (!string.IsNullOrEmpty(words.ToString()))

                resultWord = string.Join("\t", words);
            else return "Exception";

            return resultWord;
        }
    }
}
