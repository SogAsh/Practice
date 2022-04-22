using System;
using System.Collections;
using System.Collections.Generic;

namespace Company
{
    public class EnumeratorClass : IEnumerator<string>
    {
        public EnumeratorClass(string[] array)
        {
            days = array;
        }
        
        public string[] days;
        public int position = -1;
        
        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }
        public bool MoveNext()
        {
            if (position < days.Length - 1)
            {
                position++;
                return true;
            }
            else return false;
        }
        public void Reset()
        {
            position = -1;
        }
        public string Current
        {
            get
            {
                if (position == -1 || position >= days.Length)
                {
                    throw new ArgumentException();
                }

                return days[position];
            }
        }
        object IEnumerator.Current => Current;
    }
}