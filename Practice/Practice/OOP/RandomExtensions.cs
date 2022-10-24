using System;

namespace Practice.OOP
{
    //ulearn Методы расширения https://ulearn.me/Course/BasicProgramming/Metody_rasshireniya_01a1f9a5-c475-4af3-bef3-060f92e69a92
    public static class RandomExtensions //static обязательно для статических классов   
                                        //и все члены класса тоже должны быть static
    {
        public static double NextDouble(this Random rnd, double min, double max) 
                                                //this значит, что это метод расширения
                                                //this значит, что я хочу статический метод NextDouble (который выше) присоединить как динамический метод
                                                //см. rnd.NextDouble(10, 20) в методе NewMain3()
                                                //а без this, я не сомгу использовать rnd.NextDouble(10, 20) в методе NewMain3()
        {
            var a = max - min;
            var b = rnd.NextDouble() * a;
            var c = b + min;
            return c;
            //ИЛИ return rnd.NextDouble() * (max - min) + min;
        }
    }

    public static class Program3
    {
        public static void NewMain3()
        {
            var rnd = new Random();

            Console.WriteLine("rnd.NextDouble()");
            Console.WriteLine(rnd.NextDouble());

            Console.WriteLine("rnd.NextDouble(10, 20)");
            Console.WriteLine(rnd.NextDouble(10, 20)); //метод NextDouble тут вызван как динамический (для этого нужен this)
            //или так
            Console.WriteLine("RandomExtensions.NextDouble(rnd, 10, 20)");
            Console.WriteLine(RandomExtensions.NextDouble(rnd, 10, 20)); //метод NextDouble тут вызван как статический
        }
    }
}