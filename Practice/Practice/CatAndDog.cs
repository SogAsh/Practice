using System;

namespace Practice
{
    public class CatAndDog : Animal
    {
        public static void MethodCatAndDog()
        {
            Animal cat = new Animal();
            cat.name = "Barsik"; //имя присвоелось прям в классу Animal
            cat.age = 3;
            Animal.count++;

            Console.WriteLine("cat.name " + cat.name);
            Console.WriteLine("cat.age " + cat.age);
            cat.Print();
            Animal.count++;
            
            Animal dog = new Animal(); //объект класса Animal создается заново
            //с изначальными значениями переменных
            Animal.count++;
            Console.WriteLine(Animal.count);

            CatAndDog catAndDog = new CatAndDog();
            catAndDog.size = "10";
        }
    }
}