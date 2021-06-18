using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice
{
    public class BenfordStatistics
    {
        /*
         *  BenfordStatistics.PrintNumbers(GetBenfordStatistics("1"));
            BenfordStatistics.PrintNumbers(GetBenfordStatistics("abc"));
            BenfordStatistics.PrintNumbers(GetBenfordStatistics("123 456 789"));
            BenfordStatistics.PrintNumbers(GetBenfordStatistics("abc 123 def 456 gf 789 i"));
            BenfordStatistics.PrintNumbers(GetBenfordStatistics(tallestBuildings));
         */
        //не правильно
        public static int[] GetBenfordStatistics(string text)  
        {
            var statistics = new int[10];

            string[] line = text.Split(' ');

            for (int i = 0; i < line.Length; i++) //"123"
            {
                //text -> char

                if (char.IsDigit(line[i][0]) //char (char - '0') is int?
                    && (!string.IsNullOrEmpty(line[i]))) 
                    statistics[line[i][0] - '0'] += 1; //"1"
                continue;
            }

            return statistics;
        }
    }
}