using System;

namespace Practice.Inheritance
{
    public class NewPoint : object
    {
        public int X;
        public int Y;
        
        public override string ToString() //Полиморфизм
        {
            return string.Format("X={0}, Y={1}", X, Y);
        }
    }

    public class Program33
    {
        public void Print3(object obj)
        {
            var str = obj.ToString();
            Console.WriteLine(str);
        }
        
        public void Main3()
        {
            var point = new NewPoint { X = 1, Y = 3 };
            var arr = new int[] { 1, 2, 3 };
            
            Console.WriteLine(point);
            Console.WriteLine(arr);

            Print3(point);
            Print3(arr);
        }
    }

}