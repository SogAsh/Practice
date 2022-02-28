using System;

namespace Practice.OOP
{
    class RightTriangle
    {
        public double Hypothenuse; // динамическое поле
        public double[] Cathetes; // динамическое поле

        public static double AngleBetweenCathetes; // статическое поле
    }

    class NewProgram2
    {
        static void NewMain()
        {
            // RightTriangle — это тип данных, который определяет, какую информацию
            // и как мы храним в файле о прямоугольном треугольнике

            // firstTriangle — это конкретная область памяти, отформатированная в соответствии с типом RightTriangle

            var firstTriangle = new RightTriangle();

            // Обращение к динамическому полю
            firstTriangle.Hypothenuse = 5;
            firstTriangle.Cathetes = new double[2];
            firstTriangle.Cathetes[0] = 3;
            firstTriangle.Cathetes[1] = 4;

            //Обращение к статическому полю
            RightTriangle.AngleBetweenCathetes = Math.PI / 2;
        }
    }
}