using System;
using System.Collections.Generic;

namespace Practice
{
    internal class Program
    {
        public static void Method0_0()
        {
            //Уроки C# (C sharp) | #4 - Переменные. Типы переменных
            int num = 10; //может быть с "-"
            uint num1 = 10; //только "положительный "+" int

            double num2 = 34.54; //большая точность чем float
            float num3 = 1.39f;

            bool num4 = true;

            string stringVal = "er";
            char num5 = 'A';

            //преобразование типов
            num2 = num; //double = int
            num = (int)(num2); //int = double

            float d = (float)(num2); //float = double

            long e = 30;

            byte a = 4; // 0 до 255
            byte b = (byte)(a + 3);
            short c = (short)(a + 3);

            Console.WriteLine("Hello\nEveryone" + "\n" + num2 + "\n" + num3 + "\n" + num4 + "\n" + stringVal);
        }

        public static void Method0()
        {
            int num, num_1;

            Console.WriteLine("Enter first num: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter second num: ");
            num_1 = Convert.ToInt32(Console.ReadLine());
            int sum = num * num_1;

            Console.WriteLine(sum);
        }

        public static void Method2() //Уроки C# (C sharp) | #5 - Арифметические операции
        {
            const int num2 = 10;

            int num3 = 1;
            num3 += 2;
            num3++;

            Console.WriteLine(num3);
        }

        public static void Method3() //Уроки C# (C sharp) | #6 - Условные операторы
        {
            double num4;

            Console.WriteLine("How old are you");
            num4 = Convert.ToDouble(Console.ReadLine());

            if (num4 >= 64)
            {
                Console.WriteLine("You are too older than 63");
                return; //вылетаю из метода
            }
            else if (num4 >= 18)
            {
                Console.WriteLine("You are older than 18");
                //выход из области видимости {}
            }
            else
            {
                Console.WriteLine("You are younger than 18");
            }

            Console.WriteLine("Test");
            Console.ReadKey();
        }

        public static void Method4() //Уроки C# (C sharp) | #7 - Оператор Switch
        {
            Random rand = new Random();

            int num5;
            Console.WriteLine("How old are you");
            num5 = rand.Next(1, 70); //рандом от [1 до 70)

            switch (num5)
            {
                case 17:
                    Console.WriteLine(num5 + "\nYou are older than 18");
                    break;

                case 18:
                    Console.WriteLine(num5 + "\nYou are older than 18");
                    break;

                case 19:
                    Console.WriteLine(num5 + "\nYou are older than 18");
                    break;

                default:
                    Console.WriteLine(num5 + "\nYou are ??");
                    break;
            }
            Console.ReadKey();
        }

        public static void Method5() //Уроки C# (C sharp) | #8 - Циклы, а также операторы Break и Continue
        {
            for (int a = 0; a <= 10; a += 2)
            {
                Console.WriteLine(a + "\n");
            }

            int i = 0;
            while (i <= 6)
            {
                Console.WriteLine(i + "\n");
                i++;
            }

            int b;
            do
            {
                Console.WriteLine("Enter number ");
                b = Convert.ToInt32(Console.ReadLine());
            } while (b <= 10);

            for (int a = 0; a <= 10; a += 1)
            {
                if (a == 5)
                {
                    continue;
                }

                Console.WriteLine("for if continue " + a + "\n");
            }

            for (int a = 0; a <= 10; a += 1)
            {
                if (a >= 5)
                {
                    break;
                }

                Console.WriteLine("for if break " + a + "\n");
            }

            Console.ReadKey();
        }

        public static void Method6() //Уроки C# (C sharp) | #9 - Массивы
        {
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void Method7() //Уроки C# (C sharp) | #9 - Массивы
        {
            string[] array = new String[3]
            {
                "Tom", "Tom1", "Tom2"
            };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void Method8() //Уроки C# (C sharp) | #9 - Массивы
        {
            List<int> numbers = new List<int>();

            numbers.Add(11);
            numbers.Add(22);
            numbers.Add(33);
            numbers.Add(44);
            numbers.RemoveAt(2);
            numbers.Remove(22);

            //Console.WriteLine(ints[0]); или так

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static void Method9() //Уроки C# (C sharp) | #9 - Массивы
        {
            int[,] numbers2 = new int[5, 5]; //многомерные массивы

            numbers2[1, 2] = 23;

            Console.WriteLine(numbers2[1, 2]);
        }

        public static void Method10() //Уроки C# (C sharp) | #10 - Цикл foreach
        {
            int[] numbers2 = { 1, 2, 3, 4, 5 };

            foreach (var VARIABLE in numbers2)
            {
                Console.WriteLine(VARIABLE);
            }
        }

        public static int Method11(int num1, int num2) //Уроки C# (C sharp) | #11 - Методы и функции
        {
            //Console.WriteLine(num1 + num2);
            return num1 + num2;
        }

        public static void Method12() //Уроки C# (C sharp) | #12 - Работа со строками
        {
            string str = "Hello";
            string str2 = "  ";

            //Console.WriteLine(str[2]);
            //Console.WriteLine(str.Length);
            Console.WriteLine(String.IsNullOrEmpty(str2)); //нет или пусто
            Console.WriteLine(String.IsNullOrWhiteSpace(str2)); //нет или пробелы

            Console.WriteLine(String.Compare("a", "b")); //сравнение

            Console.WriteLine(str.ToLower()); //все к нижнему регистру
            Console.WriteLine(str.ToUpper()); //все к верхнему регистру

            Console.WriteLine(str.Contains("el")); //поиск подстроки

            Console.WriteLine(str.StartsWith("H")); //начинается с
            Console.WriteLine(str.EndsWith("o")); //заканчивается на

            Console.WriteLine(str.Insert(2, "ww")); //вставка символов после символа

            Console.WriteLine(str.Remove(4)); //удаление символов с

            Console.WriteLine(str.Replace("o", "oo")); //заменить на

            char[] sumb = str.ToCharArray(); //засунуть 1 строку в массив символов
            Console.WriteLine(sumb[1]);

            string strnum = "One, Two, Three"; //засунуть строки в массив строк и разделить их
            string[] numbers = strnum.Split(',');
            Console.WriteLine(numbers[1]);
        }

        public static void Method13() //Уроки C# (C sharp) | #13 - Оператор try-catch
        {
            Console.WriteLine("Введите число");

            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num);
            }
            //catch (FormatException e) //можно и так
            //{
            //    Console.WriteLine(e);
            //}
            catch (Exception) //Exception - все исключения (любые)
            {
                Console.WriteLine("Exception");
            }
            finally //код все равно сработает
            {
                Console.WriteLine("The end");
            }
        }

        public static void Addition(params int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            Console.WriteLine(result);
        }

        public static void RegularExpression()
        {
            ForRegularExpression expression = new ForRegularExpression();
            expression.RegularExpressionMethod();
        }

        private static void Main(string[] args)
        {
            //Method0_0()
            //Method();
            //Method2();
            //Method3();
            //Method4();
            //Method5();
            //Method6();
            //Method7();
            //Method8();
            //Method9();
            //Method10();

            //int res = Method11(2, 3);
            //Console.WriteLine(res);

            //Method12();
            //Method13();
            //CatAndDog.MethodCatAndDog(); //Уроки C# (C sharp) | #14 - Создание классов (Classes)

            //People man = new People(); //Уроки C# (C sharp) | #15 - Конструкторы, а также static
            //man.last_name = "Ivanov";
            //Console.WriteLine("Default constructor - last_name " + man.last_name);
            //People woman = new People("Klara", 25);

            //Уроки C# (C sharp) | #17 - Аксессоры get и set
            //Univer Alex = new Univer();
            //Console.WriteLine("В конструкторе Cource = " + Alex.Constructor); //свойтсво Constructor берет из конструктора Univer()
            //Alex.Constructor = 3;
            //Console.WriteLine("В конструкторе Cource = " + Alex.Constructor);
            //Alex.Degree = "low";
            //Console.WriteLine("В конструкторе Degree = " + Alex.Degree);

            //Уроки C# (C sharp) | #18 - Наследование
            //Reno reno = new Reno("OldReno", "male"); //инициализирую с параметрами конструктор Reno
            //reno.Name = "NewReno"; //наследование конструктора по умолчанию из класса Cars,
            //                       //т.к. Reno унаследовал и конструкторы в классе Cars
            //Console.WriteLine("Program reno.Name  = " + reno.Name);
            //reno.Method();

            //Уроки C# (C sharp) | #19 - Операторы is и as. Массив указателей
            //List<MarvelHero> marvelHero = new List<MarvelHero>(); //добавление объектов в класс MarvelHero
            //marvelHero.Add(new MarvelHero("Cap", "male"));
            //marvelHero.Add(new MarvelHero("Hulk", "nomale"));

            //#region foreach
            //foreach (MarvelHero marvelValue in marvelHero)
            //{
            //    Console.WriteLine("Имена новых объектов из List = " + marvelValue.Name);
            //}

            //foreach (MarvelHero marvelValue in marvelHero)
            //{
            //    Console.WriteLine(marvelValue is MarvelHero); //Принадлежит ли  marvelValue классу MarvelHero
            //}

            //foreach (MarvelHero marvelValue in marvelHero)
            //{
            //    Console.WriteLine(marvelValue is Hero); //Принадлежит ли  marvelValue классу Hero
            //}

            //foreach (MarvelHero marvelValue in marvelHero)
            //{
            //    Console.WriteLine(marvelValue as Hero); //Принадлежит ли  marvelValue классу Hero
            //}
            //#endregion MyRegion

            //Уроки C# (C sharp) | #20 - Виртуальные методы
            //Virtual2 virt = new Virtual2();
            //virt.Print();

            //Уроки C# (C sharp) | #21 - Абстрактные классы, методы и свойства
            //ForAbstractExample pop = new ForAbstractExample();
            //pop.Print();
            //pop.Name = "Odin";
            //Console.WriteLine(pop.Name);

            //Уроки C# (C sharp) | #22 - Интерфейсы
            //ForInterface inter = new ForInterface();
            //inter.Name = "New Interface text";
            //inter.Print();
            //inter.PrintBook();
            //Console.WriteLine(inter.Name);

            //Уроки C# (C sharp) | #23 - Перегрузка методов
            //OverloadMeth mult = new OverloadMeth();
            //mult.Multiply(2, 3);
            //Console.WriteLine();
            //mult.Multiply(2, 3, 4);
            //Console.WriteLine();
            //mult.Multiply("test");

            //Уроки C# (C sharp) | #24 - Перечисления (enum)
            //EnumMeth eenum = new EnumMeth(MyBreed.Bear);
            //eenum.Print();

            //Уроки C# (C sharp) | #25 - Структуры
            //Book one;
            //one.name = "Fant";
            //Console.WriteLine(one.name);

            //------------------------------

            //TestClass.str = "creep"; //Вызов статической переменной без создание объекта класса
            //TestClass2.Test2(); //Вызов статического метода без создание объекта класса

            //Addition(new[] { 1, 2 });
            //Addition(2, 3);
            //Addition();

            //RegularExpression();

            Byke newByke = new Byke();
            newByke.Print();
            newByke.byke.name = "Hamer";
           
            NewNewByke newNewByke = new NewNewByke(); //объекта newNewByke класса NewNewByke - наследует от IByke поведение интерфейса
            newByke.Method1(newNewByke);


            FreePracties free = new FreePracties();
            free.MethodBooks(free); //в MethodBooks положить объект free, который реализует поведение IBook
            //т.е. мы кладем туда метод void PrintBook()???


            //Console.ReadKey();
        }
    }
}