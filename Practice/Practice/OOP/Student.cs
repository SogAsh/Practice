using System;

namespace Practice.OOP
{
    public class Student
    {
        public string FirstName;
        public string LastName;
        public int Age;
    }

    public partial class NewProgram
    {
        public Student[] Students;

        public void PrintStudent(Student student)
        {
            Console.WriteLine("{0}" + " " + "{1} {2}",
                student.LastName,
                student.FirstName,
                student.Age);
        }
    }
}