namespace Practice.Structures
{
    struct Point1 //структуры это типы значений, которые хранятся по месту объявления
    {
        public int X;
        public int Y;

        public void Test()
        {
        }
    }

    public class Program12ww3
    {
        static Point1 staticPoint; //статическое поле
        Point1 dynamicPoint; //динамическо поле

        static void MainX()
        {
            //Для структур все эти инструкции будут работать
            //Для классов - не скомпилируются или выкинут null reference exception.
            Point1 point1; //локальная переменная типа point
            point1.X = 10;
            
            staticPoint.X = 10;

            var instance = new Program12ww3();
            instance.dynamicPoint.X = 10;
            
            var array = new Point1[10];
            array[0].X = 10;
        }
    }
}