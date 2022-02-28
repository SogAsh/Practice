using System;

namespace Practice.OOP
{
    class Point
    {
        public int X; //динамическое поле
        public int Y; //динамическое поле

        public void Print() //в динамическом методе можно образаться к статическим полям и к динамическим полям
        {
            Console.WriteLine("{0} {1}", X, Y);
        }

        public static void PrintPoint(Point point) //в статическом методе можно образаться только к статическим полям
        {
            Console.WriteLine("{0} {1}", point.X, point.Y);
        }
    }

    class NewProgram3
    {
        public static void NeqMain()
        {
            //вызов статического метода
            var point = new Point { X = 1, Y = 2 };
            Point.PrintPoint(point);
            
            //вызов динамического метода
            point.Print();
        }
    }
    
}