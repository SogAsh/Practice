using System;

namespace Practice.DataIntegrity
{
    public class DontDelayMistakes
    {
        public static string FormatStudent(Students1 student)
        {
            Console.WriteLine(student.Name.ToUpper());
            return student.Name.ToUpper();
        }
    }

    public class Students1
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null) throw new ArgumentException();
                name = value;
            }
        }
    }
}