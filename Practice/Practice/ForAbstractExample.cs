using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class ForAbstractExample : AbstractClass
    {
        public override void Print()
        {
            Console.WriteLine("New overrided value");
        }

        public override string Name { get; set; }
    }
}
