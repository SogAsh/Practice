using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class StrangerAgain
    {
        public  static string ApplyCommands(string[] commands)
        {
            /*
             * command.IndexOf(' ') для поиска индекса, к примеру первого пробела
             * command.Substring для взятия подстроки
             * command.Replace("cat", "dog");  ??
             *
                 * builder.Append("Some ");
                 * builder.Remove(0, 5);
                 * builder.Insert(0, "test ");
                 * builder[0] = 'T';
             */

            var builder = new StringBuilder();

            for (var i = 0; i < commands.Length; i++)
            {
                var index = commands[i].IndexOf(' ');

                if (index == 4)
                {
                    var str1 = commands[i].Remove(0, index+1);
                    builder.Append(str1);
                }
                if (index == 3)
                {
                    var str2 = commands[i].Remove(0, index + 1);
                    var b = int.Parse(str2);
                    var a = builder.Length - b;
                    builder.Remove(a, b);
                }
            }

            var str = builder.ToString();
            Console.WriteLine(str);

            return str;
        }
    }
}
