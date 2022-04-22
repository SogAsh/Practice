using System;

namespace Company
{
    public class Program
    {
        public static void Main()
        {
            Accounter accounter = new Accounter("Иван", "Иванов",
                1, "Бухгалтер", 200);

            Manager manager = new Manager("Петр", "Петров",
                2, "Менеджер", 300,
                8, 150);
            
            accounter.SetSalary(manager, 500);
            var str = manager.Salary;
            
            Console.WriteLine(str);
        }
    }
}