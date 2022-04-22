using System;

namespace Company
{
    public class Manager : Employee
    {
        public int TimeWork { get; set; }
        public int Bonus { get; set; }
        
        public Manager(string name, string lastName, 
            int id, string position, int salary,
            int timeWork, int bonus) 
            : base(name, lastName, id, position, salary)
        {
            TimeWork = timeWork;
            Bonus = bonus;
        }

        public int GatCount()
        {
            var bigBonus = Bonus * TimeWork;
            return bigBonus;
        }
    }
}