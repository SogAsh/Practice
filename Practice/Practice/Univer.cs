using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Univer //Уроки C# (C sharp) | #17 - Аксессоры get и set
    {
        private int cource;
        private string degree;

        public int Constructor //свойство
        {
            get { return cource; }
            set { cource = value; }
        }

        public string Degree //свойство
        {
            get;
            set;
        }

        public Univer() //конструктор
        {
            cource = 2;
            Console.WriteLine("Конструктор Univer cource = " + cource);

            degree = "high";
            Console.WriteLine("Конструктор Univer degree = " + degree);
        }
    }
}
