using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class NewNewByke : IByke //наследует от IByke
    {
        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }

    public class Byke
    {
        public IByke byke; //byke - объект который соответствует (поведению, т.е. методам) интерфейсу IByke

        public void Method1(IByke byke) //byke - объект который соответствует (поведению, т.е. методам) интерфейсу IByke
        {
            this.byke = byke;
        }
        public void Print()
        {
            Console.WriteLine("Some Interface text");
        }
    }
}
