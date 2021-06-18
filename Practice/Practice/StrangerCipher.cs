using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class StrangerCipher
    {
        public static string DecodeMessage(string[] lines)
        {
            List<string> list = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                var parts = lines[i].Split(' ');
                list.AddRange(parts);
            }

            string resultWord = null;

            List<string> strList = new List<string>();

            foreach (var line in list)
            {
                for (int i = 0; i < 1; i++)
                {
                    if (line == "") continue;
                    if (Char.IsUpper(line[i]))
                    {
                        //strList.Add(line);
                        //strList.Reverse();
                        strList.Insert(0, line);
                        resultWord = string.Join(" ", strList.ToArray());
                    }
                }
            }

            Console.WriteLine(resultWord);

            return resultWord;
        }
    }
}
