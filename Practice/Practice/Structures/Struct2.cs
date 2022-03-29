using System;

namespace Practice.Structures
{
    struct Point2 //структуры это типы значений, которые хранятся по месту объявления
    {
        public int X;
        public int Y;
    }

    public class Program12wуw3
    {
        static void MainX()
        {
            Point2 point1; 
            point1.X = 10;
            
            Console.WriteLine(point1.X);
        }
    }
    
    
    public class MyClass
    {
        public int classField;
    }

    public struct MyStruct
    {
        public MyClass myObject;
    }

    public class Program2
    {
        public static void ProcessStruct(MyStruct str)
        {
            str.myObject.classField = 10;
        }

        public static void Main2()
        {
            var str = new MyStruct();
            str.myObject = new MyClass();
            ProcessStruct(str);
            Console.WriteLine(str.myObject.classField);
        }
    }
}