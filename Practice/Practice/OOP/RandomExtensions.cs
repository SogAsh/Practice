using System;

namespace Practice.OOP
{
    //ulearn Методы расширения https://ulearn.me/Course/BasicProgramming/Metody_rasshireniya_01a1f9a5-c475-4af3-bef3-060f92e69a92
    public static class RandomExtensions
    {
        public static double NextDouble(this Random rnd, double min, double max) //this значит, что я хочу статический метод
                                                            //NextDouble присоединить как динамический метод к классу Random
        {
            return rnd.NextDouble() * (max - min) + min;
        }
    }

    public static class Program3
    {
        public static void NewMain3()
        {
            var rnd = new Random();
            Console.WriteLine(rnd.NextDouble(10, 20)); //метод NextDouble тут вызван как динамический
            //или так
            Console.WriteLine(RandomExtensions.NextDouble(rnd, 10, 20));
        }
    }
}