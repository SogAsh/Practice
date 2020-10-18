using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice //Уроки C# (C sharp) | #24 - Перечисления (enum)
{
    public enum MyBreed
    {
        Dog,
        Cat,
        Tiger,
        Bear
    };
    public class EnumMeth 
    {
        public MyBreed breed;
         
        public EnumMeth (MyBreed breed)
        {
            this.breed = breed;
        }

        public void Print()
        {
            Console.WriteLine(breed);
        }

    }
}
