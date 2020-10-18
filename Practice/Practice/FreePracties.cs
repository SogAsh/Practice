using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class FreePracties : IBook
    {
        public void Practies()
        {
            return parsedNumbers.Any()
                ? parsedNumbers.Sum() : 0;

            //равнозначно нижеследующему
            if (parsedNumbers.Any())
            {
                return parsedNumbers.Sum();
            }
            else
            {
                return 0;
            }
        }

        //-------------------------------------------------------------------------------------------------------
        public class Print
        {
            public string name;
        }

        public Print NewPrint() //Тип данных для выходного параметра - объектом класса Print
        {
            // Сигнатура метода (описание и структура) состоит из:
            // 1. Модификаторы доступны.
            // 2. Тип данных для выходного параметра. - может быть объектом какого-либо класса
            // 3. Имя метода.
            // 4. Входные параметры.
            Print print = new Print();
            return print;
        }

        void Main() //этот метод будет считать типо основным методом Main (для примера)
        {
            Print somePrint = NewPrint(); //Print или var, т.е. Print тут тип переменной
            somePrint.name = "";
        }

        //------------------------------------------------------------------------------------------------------------------------------
        // Интерфейс как входящий параметр фильтрует поведение объекта,
        // разрешая ему делать только то, что есть в этом интерфейсе
        public void MethodBooks(IBook some)
        {
            some.PrintBook(); //т.е. some может только вызывать поведение (т.е. метод)
            //this.some = some;
        }

        public void PrintBook() //т.к. public class FreePracties : (наследует от) IBook, то нужно реализовать метод PrintBook()
        {
            Console.WriteLine("13");
        }


        //--------------------------------------------------------------------------------------------------------
        public class Person
        {
            public int Age, Height, Weight;
            public string Name;
            public Person Parent;


            //https://habr.com/ru/post/454446/
            public Person(string name, int age, int height, int weight, Person parent)
            {
                Name = name;
                Age = age;
                Height = height;
                Weight = weight;
                Parent = parent;
            }

            void main()
            {
                Person newpers = new Person("123", 1, 2, 4, null);
                Person newpers2 = new Person("123", 1, 2, 4, newpers);
            }
        }
    }
}
