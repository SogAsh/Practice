using System;

namespace Company
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public virtual void GetFullInfo()
        {
            var fulName = Name + LastName;
            Console.WriteLine(fulName);
        }

        protected Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
    }
}