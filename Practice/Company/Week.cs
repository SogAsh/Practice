using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Company
{
    public class Week
    {
        public string[] Weekday = new[]
        {
            "Monday", "Tuesday", "Wednesday", "Thursday ", "Friday", "Saturday ", "Sunday "
        };
        
        public IEnumerator GetEnumerator()
        {
            return new EnumeratorClass(Weekday);
        }
    }
}