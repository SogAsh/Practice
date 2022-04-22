using System;

namespace Company
{
    public class Accounter : Employee
    {
        public int counts { get; set; } 
        
        public Accounter(string name, string lastName, int id, string position, int salary) 
            : base(name, lastName, id, position, salary)
        {
        }

        public int SetSalary(Employee employee, int salary)
        {
            return employee.Salary = salary;
        }
    }
}