using System;

namespace Company
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //OOP
            //     Accounter accounter = new Accounter("Иван", "Иванов",
            //         1, "Бухгалтер", 200);
            //
            //     Manager manager = new Manager("Петр", "Петров",
            //         2, "Менеджер", 300,
            //         8, 150);
            //     
            //     accounter.SetSalary(manager, 500);
            //     var newSalary = manager.Salary;
            //     
            //     Console.WriteLine(newSalary);

            //IEnumerable
            Week week = new Week();
            var getEnum = week.GetEnumerator();

            foreach (var i in week)
            {
                week.GetEnumerator();
                Console.WriteLine(i);
            }

            getEnum.MoveNext();
            var str = getEnum.Current;
            Console.WriteLine(str);
        }
    }
}