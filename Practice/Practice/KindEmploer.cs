using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class KindEmploer
    {
        public static string GetGreetingMessage(string name, double salary)
        {
            //Hello, <Name>, your salary is <Salary>.
            
            var s = string.Format("Hello, {0} , your salary is {1}", name, Math.Ceiling(salary));
            return s;
        }
    }
}
