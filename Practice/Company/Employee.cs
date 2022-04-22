using System;

namespace Company
{
    public abstract class Employee : Person
    {
        public int ID { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }

        protected Employee(string name, string lastName, int id, string position, int salary)
            : base(name, lastName)
        {
            ID = id;
            Position = position;
            Salary = salary;
        }

        public override void GetFullInfo()
        {
            base.GetFullInfo();
            var positionID = ID + Position;
            Console.WriteLine(positionID);
        }
    }
}