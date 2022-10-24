using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Practice.DataIntegrity;
using Practice.Inheritance;
using Practice.OOP;
using Practice.QueuesStacksGenerics;
using Practice.Training;
using Practice.yieldReturn;

namespace Practice
{
    internal class Program
    {
        //Уроки C# (C sharp) | #4 - Переменные. Типы переменных
        public static void Method00()
        {
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

        public static void Method01()
        {
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;

            foreach (var t in array)
            {
                Console.WriteLine(t);
            }
        }

        public static void Method02()
        {
            Console.WriteLine("Enter first num: ");
            var num = Convert.ToInt32(Console.ReadLine());

            var exception = new IndexOutOfRangeException();
            Console.WriteLine(Environment.NewLine + "Enter second num: ");

            int num_1 = Convert.ToInt32(Console.ReadLine());
            int sum = num * num_1;

            Console.WriteLine(sum);
        }

        enum MyEnum
        {
            TEST1,
            TEST2,
            TEST3,
            TEST4
        }

        public static void Method1()
        {
            int num, num_1;

            Console.WriteLine("Enter first num: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter second num: ");

            num_1 = Convert.ToInt32(Console.ReadLine());
            int sum = num * num_1;

            Console.WriteLine(sum);
        }

        //Уроки C# (C sharp) | #5 - Арифметические операции
        public static void Method2()
        {
            const int num2 = 10;

            int num3 = 1;
            num3 += 2;
            num3++;

            Console.WriteLine(num3);
        }

        //Уроки C# (C sharp) | #6 - Условные операторы
        public static void Method3()
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

        //Уроки C# (C sharp) | #7 - Оператор Switch
        public static void Method4()
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

        //Уроки C# (C sharp) | #8 - Циклы, а также операторы Break и Continue
        public static void Method5()
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

        //Уроки C# (C sharp) | #8 - Циклы, а также операторы Break и Continue
        public static void Method5_1()
        {
            var result = " ";
            for (int j = 0; j < 100; j++)
            {
                result = result + j.ToString() + ',';
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }

        //Уроки C# (C sharp) | #9 - Массивы
        public static void Method6()
        {
            //https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/boolean-logical-operators#logical-and-operator-
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

        //Уроки C# (C sharp) | #9 - Массивы
        public static void Method7()
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

        //Уроки C# (C sharp) | #9 - Массивы
        public static void Method8()
        {
            //List<List<int>> - https://youtu.be/6-cuxfD3lvg?t=253

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

        //Про List<>
        public static void Method8_1()
        {
            var list = new List<List<string>>();

            string[] arr = { "1", "2", "3" };

            for (int m = 0; m < arr.Length; m++)
            {
                var sublist = new List<string>();
                for (int i = 0; i < arr.Length; i++)
                {
                    sublist.Add(arr[i]);

                    foreach (var l in sublist)
                    {
                        Console.WriteLine("sublist = " + l);
                    }
                }

                Console.WriteLine("sublist =========END");

                list.Add(sublist);

                foreach (var b in list)
                {
                    Console.WriteLine("list =========[b]");
                    foreach (var varb in b)
                    {
                        Console.WriteLine("list = " + varb);
                    }

                    Console.WriteLine("list =========END");
                }
            }
        }

        public static void Method8_2()
        {
            // Part 1: add rows and columns to the List.
            List<List<int>> list = new List<List<int>>();
            var rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                // Put some integers in the inner lists.
                List<int> sublist = new List<int>();
                int top = rand.Next(1, 4);
                for (int v = 0; v < top; v++)
                {
                    sublist.Add(rand.Next(1, 5));
                }

                // Add the sublist to the top-level List.
                list.Add(sublist);
            }

            Display(list);
        }

        static void Display(List<List<int>> list)
        {
            // Part 2: loop over and display everything in the List.
            Console.WriteLine("Elements in list:");
            foreach (var sublist in list)
            {
                foreach (var value in sublist)
                {
                    Console.Write(value);
                    Console.Write(' ');
                }

                Console.WriteLine("");
            }

            Console.WriteLine("******************");
            // Part 3: display element.
            Console.WriteLine("Element at 1, 0:");
            Console.WriteLine(list[1][0]);
            // Part 4: display total count.
            int count = 0;
            foreach (var sublist in list)
            {
                count += sublist.Count;
            }

            Console.WriteLine("Count of elements:");
            Console.WriteLine(count);
        }

        //Уроки C# (C sharp) | #9 - Массивы
        public static void Method9()
        {
            int[,] numbers2 = new int[5, 5]; //многомерные массивы

            numbers2[1, 2] = 23;

            Console.WriteLine(numbers2[1, 2]);
        }

        //Уроки C# (C sharp) | #10 - Цикл foreach
        public static void Method10()
        {
            int[] numbers2 = { 1, 2, 3, 4, 5 };

            foreach (var VARIABLE in numbers2)
            {
                Console.WriteLine(VARIABLE);
            }
        }

        //Уроки C# (C sharp) | #11 - Методы и функции
        public static int Method11(int num1, int num2)
        {
            //Console.WriteLine(num1 + num2);
            return num1 + num2;
        }

        //Уроки C# (C sharp) | #12 - Работа со строками
        public static void Method12()
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

        //Уроки C# (C sharp) | #13 - Оператор try-catch
        public static void Method13()
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

        //Уроки C# (C sharp) | #15 - Конструкторы, а также static
        public static void Method14()
        {
            People man = new People();
            man.last_name = "Ivanov";
            Console.WriteLine("Default constructor - last_name " + man.last_name);
            People woman = new People("Klara", 25);
        }

        //Уроки C# (C sharp) | #17 - Аксессоры get и set
        public static void Method15()
        {
            Univer Alex = new Univer();
            Console.WriteLine("В конструкторе Cource = " +
                              Alex.Constructor); //свойтсво Constructor берет из конструктора Univer()
            Alex.Constructor = 3;
            Console.WriteLine("В конструкторе Cource = " + Alex.Constructor);
            Alex.Degree = "low";
            Console.WriteLine("В конструкторе Degree = " + Alex.Degree);
        }

        //Уроки C# (C sharp) | #18 - Наследование
        public static void Method16()
        {
            Reno reno = new Reno("OldReno", "male"); //инициализирую с параметрами конструктор Reno
            reno.Name = "NewReno"; //наследование конструктора по умолчанию из класса Cars,
            //т.к. Reno унаследовал и конструкторы в классе Cars
            Console.WriteLine("Program reno.Name  = " + reno.Name);
            reno.Method();
        }

        //Уроки C# (C sharp) | #19 - Операторы is и as. Массив указателей
        public static void Method17()
        {
            List<MarvelHero> marvelHero = new List<MarvelHero>(); //добавление объектов в класс MarvelHero
            marvelHero.Add(new MarvelHero("Cap", "male"));
            marvelHero.Add(new MarvelHero("Hulk", "nomale"));

            #region foreach

            foreach (MarvelHero marvelValue in marvelHero)
            {
                Console.WriteLine("Имена новых объектов из List = " + marvelValue.Name);
            }

            foreach (MarvelHero marvelValue in marvelHero)
            {
                Console.WriteLine(marvelValue is MarvelHero); //Принадлежит ли  marvelValue классу MarvelHero
            }

            foreach (MarvelHero marvelValue in marvelHero)
            {
                Console.WriteLine(marvelValue is Hero); //Принадлежит ли  marvelValue классу Hero
            }

            foreach (MarvelHero marvelValue in marvelHero)
            {
                Console.WriteLine(marvelValue as Hero); //Принадлежит ли  marvelValue классу Hero
            }

            #endregion MyRegion
        }

        //Уроки C# (C sharp) | #20 - Виртуальные методы
        public static void Method18()
        {
            Virtual2 virt = new Virtual2();
            virt.Print();
        }

        //Уроки C# (C sharp) | #21 - Абстрактные классы, методы и свойства
        public static void Method19()
        {
            ForAbstractExample pop = new ForAbstractExample();
            pop.Print();
            pop.Name = "Odin";
            Console.WriteLine(pop.Name);
        }

        //Уроки C# (C sharp) | #22 - Интерфейсы
        public static void Method20()
        {
            ForInterface inter = new ForInterface();
            inter.Name = "New Interface text";
            inter.Print();
            inter.PrintBook();
            Console.WriteLine(inter.Name);
        }

        //Уроки C# (C sharp) | #23 - Перегрузка методов
        public static void Method21()
        {
            OverloadMeth mult = new OverloadMeth();
            mult.Multiply(2, 3);
            Console.WriteLine();
            mult.Multiply(2, 3, 4);
            Console.WriteLine();
            mult.Multiply("test");
        }

        //Уроки C# (C sharp) | #24 - Перечисления (enum)
        public static void Method22()
        {
            EnumMeth eenum = new EnumMeth(MyBreed.Bear);
            eenum.Print();
        }

        //Уроки C# (C sharp) | #25 - Структуры
        public static void Method23()
        {
            Book one;
            one.name = "Fant";
            Console.WriteLine(one.name);
        }

        //Ошибки преобразования типов
        public static void Method24()
        {
            double pi = Math.PI;
            float newPi = (float)pi;
            long tenThousand = 10000L;
            double tenThousandPi = newPi * tenThousand;
            int roundedTenThousandPi = (int)Math.Round(tenThousandPi); //округление до ближайшего целого числа
            int integerPartOfTenThousandPi = (int)tenThousandPi;
            Console.WriteLine(integerPartOfTenThousandPi);
            Console.WriteLine(roundedTenThousandPi);
        }

        public static void Method25()
        {
            double amount = 1.11;
            int peopleCount = 60;
            int totalMoney = (int)Math.Round(amount * peopleCount); //округление до ближайшего целого числа
            Console.WriteLine(totalMoney);
        }

        //Преобразование строки в число
        public static void Method26()
        {
            string doubleNumber = "894376.243643";
            double number = double.Parse(doubleNumber); //работает в старой студии
            Console.WriteLine(number + 1);
        }

        //Использование var
        public static void Method27()
        {
            double a = 5;
            a += 0.5;
            Console.WriteLine(a);
        }

        //ulearn Главный вопрос Вселенной https://ulearn.me/course/basicprogramming/Glavnyy_vopros_Vselennoy_d5b59540-410f-4f6d-8f04-b5613e264bd5
        public static void Method28()
        {
            MainQuestionUniverse.NewPrint(MainQuestionUniverse.GetSquare(42));
        }

        public static void Method29(int a, int b, int c)
        {
            // if ((a < 0) || (a == 0 && b != 0))
            //     return "Impossible";
            // else
            // {
            //     if (a == 0 && b == 0)
            //         return c.ToString();
            //     else
            //         return (-b / (2 * a)).ToString();
            // }
        }

        public static void Method30()
        {
            // Console.WriteLine(Method18(1, 2, 3));
            // Console.WriteLine(Method18(0, 3, 2));
            // Console.WriteLine(Method18(1, -2, -3));
            // Console.WriteLine(Method18(5, 2, 1));
            // Console.WriteLine(Method18(4, 3, 2));
            // Console.WriteLine(Method18(0, 4, 5));
            //
            // //А в этих случаях решение существует:
            // Console.WriteLine(Method18(0, 0, 2) != "Impossible");
            // Console.WriteLine(Method18(0, 0, 0) != "Impossible");
        }

        //ulearn Добрый работодатель https://ulearn.me/course/basicprogramming/Dobryy_rabotodatel__f6559650-b3af-4e5e-be84-941fb21bc2ac
        public static void Method31()
        {
            Console.WriteLine(KindEmploer.GetGreetingMessage("Student", 10.01));
            Console.WriteLine(KindEmploer.GetGreetingMessage("Bill Gates", 10000000.5));
            Console.WriteLine(KindEmploer.GetGreetingMessage("Steve Jobs", 1));
        }

        //ulearn Разыскиваются методы! https://ulearn.me/Course/BasicProgramming/Razyskivayutsya_metody__d8578c7f-d7e2-4ce5-a3be-e6e32d9ac63e
        public static void Method32()
        {
            Console.WriteLine(MethodsWanted.GetLastHalf("I love CSharp!"));
            Console.WriteLine(MethodsWanted.GetLastHalf("1234567890"));
            Console.WriteLine(MethodsWanted.GetLastHalf("до ре ми фа соль ля си"));
        }

        //ulearn Високосный год https://ulearn.me/course/basicprogramming/Visokosnyy_god_4c161b1e-2637-447b-adfd-14647bf659ad?autoplay=true
        public static void Method33()
        {
            LeapYear LeapYear = new LeapYear();
            Console.WriteLine(LeapYear.IsLeapYear(1700));
            Console.WriteLine(LeapYear.IsLeapYear(1999));
            Console.WriteLine(LeapYear.IsLeapYear(8992));
            Console.WriteLine(LeapYear.IsLeapYear(1));
            Console.WriteLine(LeapYear.IsLeapYear(14));
            Console.WriteLine(LeapYear.IsLeapYear(400));
            Console.WriteLine(LeapYear.IsLeapYear(600));
            Console.WriteLine(LeapYear.IsLeapYear(3200));
        }

        //ulearn Сравнение чисел с плавающей точкой https://ulearn.me/course/basicprogramming/Sravnenie_chisel_s_plavayushchey_tochkoy_1e844dc5-c026-4acc-b28f-086a2e7c6f8e
        public static void Method34()
        {
            //в бинарном виде 0.1 представляется бесконечной дробью 0.00011001100..., в типах данных float и double хранится только начало этой дроби, поэтому число 0.1 представляется с погрешностью. 
            double x = 1.0 / 10;
            double sum = 0;
            for (int i = 0; i < 10; i++) sum += x;
            Console.WriteLine(Math.Abs(sum - 1) <
                              1e-9); //Здесь мы проверяем, что числа равны не в точности, но что модуль их разности меньше некоторого маленького числа. Всегда используйте такую конструкцию при сравнении чисел с плавающей точкой.
        }

        //ulearn Ход ферзя https://ulearn.me/course/basicprogramming/Khod_ferzya_eb11dfb6-5629-4d13-819b-6411b9f93df6?autoplay=true
        public static void Method35()
        {
            TheCourseOfQueen TheCourseOfQueen = new TheCourseOfQueen();
            TheCourseOfQueen.TestMove("a1", "d4");
            TheCourseOfQueen.TestMove("f4", "e7");
            TheCourseOfQueen.TestMove("a1", "a4");
            TheCourseOfQueen.TestMove("a1", "a1");
        }

        //ulearn Среднее трех https://ulearn.me/course/basicprogramming/Srednee_trekh_937c4e64-7144-4f52-a75d-4bdc95bbde72?autoplay=true
        public static void Method36()
        {
            Console.WriteLine(AverageOfThree.MiddleOf(5, 0, 100)); // => 5
            Console.WriteLine(AverageOfThree.MiddleOf(12, 12, 11)); // => 12
            Console.WriteLine(AverageOfThree.MiddleOf(1, 1, 1)); // => 1
            Console.WriteLine(AverageOfThree.MiddleOf(2, 3, 2)); //2
            Console.WriteLine(AverageOfThree.MiddleOf(8, 8, 8)); //8
            Console.WriteLine(AverageOfThree.MiddleOf(5, 0, 1)); //1
            Console.WriteLine(AverageOfThree.MiddleOf(47, 15, 19)); //19
            Console.WriteLine(AverageOfThree.MiddleOf(11, 97, 97)); //97
        }

        //ulearn Управление роботом https://ulearn.me/course/basicprogramming/Upravlenie_robotom_50ac4fc7-a6e1-4c4e-8c61-ecc75aeb912e
        public static void Method37()
        {
            RobotManage RobotManage = new RobotManage();
            RobotManage.ShouldFire(true, "boss", 70);
            RobotManage.ShouldFire2(true, "boss", 70);
        }

        //ulearn В поисках степени двойки https://ulearn.me/course/basicprogramming/V_poiskakh_stepeni_dvoyki_4158c9a6-a71d-4015-a283-def12be0055e
        public static void Method38()
        {
            // Console.WriteLine(InSearchOfThePowerOfTwo.GetMinPowerOfTwoLargerThan(2)); // => 4
            // Console.WriteLine(InSearchOfThePowerOfTwo.GetMinPowerOfTwoLargerThan(15)); // => 16
            // Console.WriteLine(InSearchOfThePowerOfTwo.GetMinPowerOfTwoLargerThan(-2)); // => 1
            // Console.WriteLine(InSearchOfThePowerOfTwo.GetMinPowerOfTwoLargerThan(-100));
            // Console.WriteLine(InSearchOfThePowerOfTwo.GetMinPowerOfTwoLargerThan(100));
        }

        //ulearn Убрать пробелы https://ulearn.me/course/basicprogramming/Ubrat_probely_9a15ebd5-0616-4a18-b842-e63e2c3c21fa
        public static void Method39()
        {
            Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces("a"));
            Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces(" b"));
            Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces(" cd"));
            Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces(" efg"));
            Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces(" text"));
            Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces(" two words"));
            Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces("  two spaces"));
            Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces("	tabs"));
            Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces("		two	tabs"));
            Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces("                             many spaces"));
            Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces("               "));
            Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces("\n\r line breaks are spaces too"));
        }

        //ulearn Рамочка https://ulearn.me/course/basicprogramming/Ramochka_6923aa65-95e0-4b5e-a98d-b286fd0b2153
        public static void Method40()
        {
            Frame.WriteTextWithBorder("Menu:");
            Frame.WriteTextWithBorder("");
            Frame.WriteTextWithBorder(" ");
            Frame.WriteTextWithBorder("Game Over!");
            Frame.WriteTextWithBorder("Select level:");
        }

        //ulearn Шахматная доска https://ulearn.me/course/basicprogramming/_Shakhmatnaya_doska_8e561342-9f4b-411d-bb9b-741a3677f696
        public static void Method41()
        {
            Chess.WriteBoard(8);
            Chess.WriteBoard(1);
            Chess.WriteBoard(2);
            Chess.WriteBoard(3);
            Chess.WriteBoard(10);
        }

        //ulearn Четный массив https://ulearn.me/course/basicprogramming/Chetnyy_massiv_ceb81eac-069c-4d5d-87b7-ebd9b140e143?autoplay=true
        public static void Method42()
        {
            BlackArray.GetFirstEvenNumbers(3);
            BlackArray.GetFirstEvenNumbers(2);
            BlackArray.GetFirstEvenNumbers(4);
        }

        //ulearn Индекс максимума https://ulearn.me/course/basicprogramming/Indeks_maksimuma_043015a0-0b28-4435-8079-21e4ca8e6526
        public static void Method43()
        {
            // double[] a0 = new double [0];
            // double[] a = { 1, 9, 9, 8, 9, 2, 2 };
            // double[] b = { 1, 2, 46, 14, 64, 64 };
            // double[] d = { 1, 2, 3 };
            // Console.WriteLine(MaxMinAndIndex.MaxIndex(a0));
            // Console.WriteLine(MaxMinAndIndex.MaxIndex(a));
            // Console.WriteLine(MaxMinAndIndex.MaxIndex(b));
            // Console.WriteLine(MaxMinAndIndex.MaxIndex(d));
            
            // Console.WriteLine(MaxIndexGeneralClass.MaxGeneralMethod(new int[0]));
            Console.WriteLine(MaxIndexGeneralClass.MaxGeneralMethod(new[] { 3 }));
            Console.WriteLine(MaxIndexGeneralClass.MaxGeneralMethod(new[] { 3, 1, 2 }));
            Console.WriteLine(MaxIndexGeneralClass.MaxGeneralMethod(new[] { "A", "B", "C" }));
        }

        //ulearn Подсчет https://ulearn.me/course/basicprogramming/Podschet_9eb1a5c2-135d-49a5-a922-0f3f91566080
        public static void Method44()
        {
            int[] a = { 1, 2, 1, 1 };
            Console.WriteLine(Count.GetElementCount(a, 1));
        }

        //ulearn Поиск массива в массиве https://ulearn.me/course/basicprogramming/Poisk_massiva_v_massive_df8d1ca7-9aab-4816-8047-a834c6ca64d4
        public static void Method45()
        {
            int[] array = { 1, 6, 2, 3, 4, 3, 4 };
            int[] subarray = { 3, 4, 9 };
            SearchArrayIntoArray.FindSubarrayStartIndex(array, subarray);
        }

        //ulearn Карты Таро https://ulearn.me/course/basicprogramming/Karty_Taro_26c265ba-ea70-4aa9-bf6b-5c215576a3ab
        public static void Method46()
        {
            Console.WriteLine(Taro.GetSuit(Taro.Suits.Wands));
            Console.WriteLine(Taro.GetSuit(Taro.Suits.Coins));
            Console.WriteLine(Taro.GetSuit(Taro.Suits.Cups));
            Console.WriteLine(Taro.GetSuit(Taro.Suits.Swords));
        }

        //FluentAPI Более сложный случай https://ulearn.me/course/cs2/Bolee_slozhnyy_sluchay_df079b25-8952-4d6f-976b-f92b17c93005
        public static void Method47()
        {
            var spectacle = new Spectacle()
                .Say("Привет мир!")
                .Delay(TimeSpan.FromSeconds(1))
                .UntilKeyPressed(s =>
                    s.Say("тра-ля-ля")
                        .Delay(TimeSpan.FromMilliseconds(500))
                        .Say("тру-лю-лю")
                        .Delay(TimeSpan.FromMilliseconds(500))
                )
                .Say("Пока-пока!");
            spectacle.Play();
        }

        //FluentAPI Расширяемость Fluent-Интерфейсов https://ulearn.me/course/cs2/Rasshiryaemost_Fluent_Interfeysov_30c4a153-5510-4015-ab90-98e259b8da7f
        public static void Method48()
        {
            var newSpectacle = new NewSpectacle()
                .Say("Привет мир!")
                .Delay(TimeSpan.FromSeconds(1))
                .UntilKeyPressed(s =>
                    s.TypeText("тра-ля-ля")
                        .TypeText("тру-лю-лю")
                )
                .Say("Пока-пока!");

            newSpectacle.Play();
        }

        //ulearn Null или не Null? https://ulearn.me/course/basicprogramming/Null_ili_ne_Null__05581efc-0377-438e-b6c6-90778d3c8922
        public static void Method49()
        {
            Console.WriteLine(NullOrNotNull.CheckFirstElement(null));
            Console.WriteLine(NullOrNotNull.CheckFirstElement(new int[0]));
            Console.WriteLine(NullOrNotNull.CheckFirstElement(new[] { 1 }));
            Console.WriteLine(NullOrNotNull.CheckFirstElement(new[] { 0 }));
        }

        //ulearn Возвести массив в степень https://ulearn.me/course/basicprogramming/Vozvesti_massiv_v_stepen__e3e45ec7-7bd0-4284-8ca1-0fbcb2fa0c21
        public static void Method50()
        {
            var arrayToPower = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // Метод PrintArray уже написан за вас
            RaiseAnArayToADegree.PrintArray(RaiseAnArayToADegree.GetPoweredArray(arrayToPower, 1));
            // если вы будете менять исходный массив, то следующие два теста сработают неверно:
            RaiseAnArayToADegree.PrintArray(RaiseAnArayToADegree.GetPoweredArray(arrayToPower, 2));
            RaiseAnArayToADegree.PrintArray(RaiseAnArayToADegree.GetPoweredArray(arrayToPower, 3));
            // не забывайте про частные случаи:
            RaiseAnArayToADegree.PrintArray(RaiseAnArayToADegree.GetPoweredArray(new int[0], 1));
            RaiseAnArayToADegree.PrintArray(RaiseAnArayToADegree.GetPoweredArray(new[] { 42 }, 0));
        }

        //НЕ РЕШИЛ //ulearn Крестики-нолики https://ulearn.me/course/basicprogramming/_Krestiki_noliki_b4f3138d-5cdb-4f8a-9976-e0f4d379687a?autoplay=true
        public static void Method51()
        {
            TicTacToe.Run("XXX OO. ...");
            TicTacToe.Run("OXO XO. .XO");
            TicTacToe.Run("OXO XOX OX.");
            TicTacToe.Run("XOX OXO OXO");
            TicTacToe.Run("... ... ...");
            TicTacToe.Run("XXX OOO ...");
            TicTacToe.Run("XOO XOO XX.");
            TicTacToe.Run(".O. XO. XOX");
        }

        //ulearn Шифр незнакомки https://ulearn.me/course/basicprogramming/Shifr_neznakomki_673c8a47-9560-4458-9bd9-a0c0b58466aa?autoplay=true
        public static void Method52()
        {
            string[] lines = File.ReadAllLines("cipher.txt");
            string[] parts;
            List<string> list = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                parts = lines[i].Split(' ');
                list.AddRange(parts);
            }

            StrangerCipher.DecodeMessage(list.ToArray());
        }

        //ulearn Полезные знакомства https://ulearn.me/course/basicprogramming/Poleznye_znakomstva_9a4d5ff4-2331-4bef-a3ee-88e54bec88c8?autoplay=true
        public static void Method53()
        {
            List<string> addr = new List<string>();
            addr.Add("Sаsha:sasha1995@sasha.ru");
            addr.Add("Sаsha:alex99@mail.ru");
            addr.Add("Sаsha:shurik2020@google.com");
            addr.Add("Petya:petya@google.com");

            UsefulAcquaintances.OptimizeContacts(addr);
        }

        //ulearn Практика «Частотность N-грамм» https://ulearn.me/course/basicprogramming/Praktika_Chastotnost_N_gramm__eb894d4d-5854-4684-898b-5480895685e5
        public static Dictionary<string, int> PracticeFrequencyNgram()
        {
            string text = "a b c d. b c d. e b c a f"; //d
            var dict = ClassPracticeFrequencyNgram.MethodPracticeFrequencyNgram(text);
            return dict;
        }

        //ulearn Закон Бенфорда https://ulearn.me/course/basicprogramming/Zakon_Benforda_66e248f0-2828-4e23-8d47-eb4e1cdb64b9
        public static void Method54()
        {
            BenfordStatistics.GetBenfordStatistics("1");
            BenfordStatistics.GetBenfordStatistics("abc");
            BenfordStatistics.GetBenfordStatistics("123 456 789");
            BenfordStatistics.GetBenfordStatistics("abc 123 def 456 gf 789 i");

            string[] tallestBuildings = File.ReadAllLines("tallestBuildings.txt");
            for (int i = 0; i < tallestBuildings.Length; i++)
            {
                string[] parts;
                parts = tallestBuildings[i].Split('\n');
                BenfordStatistics.GetBenfordStatistics(parts.ToString());
            }
        }

        //ulearn Split и Join //https://ulearn.me/course/basicprogramming/Split_i_Join_0260707c-b6f6-4e93-b445-68962b241709
        public static void Method55()
        {
            string[] citiesPopulation = File.ReadAllLines("citiesPopulation.txt");
            string citiesPopulation2 = string.Join("\n", citiesPopulation);
            Console.WriteLine(ReplaceSeparators.ReplaceIncorrectSeparators(citiesPopulation2));
        }

        //ulearn Снова незнакомка https://ulearn.me/course/basicprogramming/Snova_neznakomka_741d39bd-d543-40d2-abbc-941c7f778106
        public static void Method56()
        {
            string[] StrangerAgainText = File.ReadAllLines("StrangerAgainText.txt");
            StrangerAgain.ApplyCommands(StrangerAgainText);
        }

        //ulearn Рекурсия https://ulearn.me/course/basicprogramming/Rekursiya_caec41b0-3166-40c0-9ded-3941c7f0b91d
        public static void Method57(int n)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(i + " ");
                Method57(i);
            }
        }
        //Исправить рекурсию https://ulearn.me/course/basicprogramming/Ispravit_rekursiyu_a5ba07a0-3b06-424b-989a-330137c1c05e
        public static void Method58()
        {
            var items = new[] { 'a', 'b', 'c' };
            FixRecursion.WriteReversed(items, 0);
        }
        //Задание №18: техники белого ящика https://ulearn.me/course/testdesign/Zadanie_18_tekhniki_belogo_yashchika_88ad9b85-8aa5-4b9f-942b-3a47ffcdd60c
        public static void Method59()
        {
            var x = 1;
            var y = x;
            var A = 11;
            var B = 5;
            if (A > 10)
            {
                x = 10;
            }
            if (B == 5)
            {
                y = 10;
            }
            else
            {
                y = 55;
            }
        }
        //ulearn Основы ООП https://ulearn.me/course/basicprogramming/Klassy_9eb68528-17cb-4d7f-99f3-40210a8f6cef
        public static void Method60()
        {
            var newProgram = new NewProgram();

            newProgram.Students = new[]
            {
                new Student { FirstName = "John", LastName = "Johnes", Age = 18 },
                new Student { FirstName = "William", LastName = "Williams", Age = 25 }
            };

            newProgram.PrintStudent(newProgram.Students[0]);
            newProgram.PrintStudent(newProgram.Students[1]);
        }

        //ulearn Создание классов https://ulearn.me/course/basicprogramming/Sozdanie_klassov_b0529ff4-52d1-4462-865b-89920b240f57
        public static void Method61()
        {
            var city = new City();
            city.Name = "Ekaterinburg";
            city.Location = new GeoLocation();
            city.Location.Latitude = 56.50;
            city.Location.Longitude = 60.35;
            Console.WriteLine("I love {0} located at ({1}, {2})",
                city.Name,
                city.Location.Longitude.ToString(CultureInfo.InvariantCulture),
                city.Location.Latitude.ToString(CultureInfo.InvariantCulture));
        }

        //ulearn Создание классов https://ulearn.me/course/basicprogramming/Sozdanie_klassov_b0529ff4-52d1-4462-865b-89920b240f57
        public static void Method62()
        {
            DirectoryInfoAndFileInfo.NewMain3();
        }
        
        //Постановка проблемы https://ulearn.me/course/basicprogramming/Postanovka_problemy_a969ed1f-fc3e-4dcc-8d05-6015069e3dcf
        public static void Method63()
        {
            BumbleSort.MakeBumbleSortMethod_WithNewMethod();
        }
        
        //Склейка массивов https://ulearn.me/course/basicprogramming/Skleyka_massivov_3a0b67fc-73c1-498a-b015-7ccc06b7ffc9
        public static void Method64()
        {
            var ints = new[] { 1, 2 };
            var strings = new[] { "A", "B" };

            CombineClass.Print(CombineClass.Combine(ints, ints));
            CombineClass.Print(CombineClass.Combine(ints, ints, ints));
            CombineClass.Print(CombineClass.Combine(ints));
            CombineClass.Print(CombineClass.Combine());
            CombineClass.Print(CombineClass.Combine(strings, strings));
            CombineClass.Print(CombineClass.Combine(ints, strings));
        }
        
        //Снова среднее трех https://ulearn.me/course/basicprogramming/Snova_srednee_trekh_3dff4d01-45d2-4f80-889d-75ed651b31c2
        public static void Method65()
        {
            Console.WriteLine(AverageOfThree.MiddleOfThree(2, 5, 4));
            Console.WriteLine(AverageOfThree.MiddleOfThree(3, 1, 2));
            Console.WriteLine(AverageOfThree.MiddleOfThree(3, 5, 9));
            Console.WriteLine(AverageOfThree.MiddleOfThree("B", "Z", "A"));
            Console.WriteLine(AverageOfThree.MiddleOfThree(3.45, 2.67, 3.12));
        }
        
        //Поиск минимума https://ulearn.me/course/basicprogramming/Poisk_minimuma_9e6c6fe1-9282-4abc-853c-5ce6fb5bfa76?autoplay=true
        public static void Method66()
        {
            Console.WriteLine(MaxMinAndIndex.MinGeneral(new[] { 3, 6, 2, 4 }));
            Console.WriteLine(MaxMinAndIndex.MinGeneral(new[] { "B", "A", "C", "D" }));
            Console.WriteLine(MaxMinAndIndex.MinGeneral(new[] { '4', '2', '7' }));
        }
        
        //Сравнение книг https://ulearn.me/course/basicprogramming/Sravnenie_knig_bd1f8054-a372-4ea4-9f5a-2eee97cd2b71
        // public static void Method67()
        // {
        //     Console.WriteLine(Inheritance.Book.CompareTo);
        // }

        //Виртуальные методы https://ulearn.me/course/basicprogramming/Virtual_nye_metody_4c2cab0b-93dd-48ce-88ac-5115d9655642
        public static void Method68()
        {
            var ere = new Program33();
            ere.Main3();
        }
        
        //Метод ToString https://ulearn.me/course/basicprogramming/Metod_ToString_910105f8-f895-4608-9134-8b8d42d68e41
        public static void Method69()
        {
            var triangle = new Triangle
            {
                A = new PointTriangle { X = 0, Y = 0 },
                B = new PointTriangle { X = 1, Y = 2 },
                C = new PointTriangle { X = 3, Y = 2 }
            };
            Console.WriteLine(triangle.ToString());
        }
        
        public static void Method70()
        {
            Program32.Main33();
        }
        
        //Отложенные ошибки https://ulearn.me/course/basicprogramming/Otlozhennye_oshibki_3bf0e956-3258-4a4d-ac42-926dc8cbad3b
        public static void Method71()
        {
            UnsafeProgram.Main2323();
        }
        
        //Не откладывать ошибки https://ulearn.me/course/basicprogramming/Ne_otkladyvat_oshibki_9eb0e353-bb50-4ae0-9064-e8bb86dd33de
        public static void Method72()
        {
            var _srudent = new Students1()
            {
                Name = "Иван"
            };
            
            DontDelayMistakes.FormatStudent(_srudent);
        }
        
        //Свойство вместо поля https://ulearn.me/course/basicprogramming/Svoystvo_vmesto_polya_3adad7ba-a462-49d5-8677-7d1f8c85af33
        public static void Method73()
        {
            PropertyInsteadOfField.Check1();
        }
        
        //Конструкторы https://ulearn.me/course/basicprogramming/Konstruktory_87ee724d-8b7d-4d9e-b4f7-ea29c0f055ff
        public static void Method74()
        {
            Programs123.Maintest1();
        }
        
        //Вектор https://ulearn.me/course/basicprogramming/vektor_6011b77e-b481-445d-9823-93e6a57fd757
        public static void Method75()
        {
            Vector.Check();
        }
        
        //Дробь https://ulearn.me/course/basicprogramming/Drob__deeef0d7-5d5c-481a-9a07-480641705efe
        public static void Method76()
        {
            Ratio.Check(1, 2);
        }

        public static void Method77()
        {
            Task1.CountElements();
        }
        
        //Стеки и очереди https://ulearn.me/course/basicprogramming2/Steki_i_ocheredi_48016626-87ae-411d-ae97-f7a49e465dbc
        public static void Method78()
        {
            Program123.Mian();
        }
        
        //Очередь на связных списках https://ulearn.me/course/basicprogramming2/Ochered_na_svyaznykh_spiskakh_ee9122e3-6381-437d-9c6c-b8873bd5165f
        public static void Method79()
        {
            Program1234.Main1234();
        }
        
        //Максимум в массиве https://ulearn.me/course/basicprogramming2/Maksimum_v_massive_e3f3c78d-8d68-40cb-8b1e-a1912396dbef
        public static void Method80()
        {
            // Console.WriteLine(MaxIndexGeneralClass.Max(new int[0]));
            // Console.WriteLine(MaxIndexGeneralClass.Max(new[] { 3 }));
            // Console.WriteLine(MaxIndexGeneralClass.Max(new[] { 3, 1, 2 }));
            // Console.WriteLine(MaxIndexGeneralClass.Max(new[] { "A", "B", "C" }));
        }
        
        //foreach, IEnumerable и IEnumerator https://ulearn.me/course/basicprogramming2/foreach_IEnumerable_i_IEnumerator_49c485c2-d2a7-4362-a473-5757719bd002
        public static void Method81()
        {
            Programc1234Generic.Mainc1234();
        }
        
        public static void Method82()
        {
            Program3.NewMain3();
        }

        private static void Main()
        {
            // int res = Method11(2, 3);
            // Console.WriteLine(res);
            //
            // CatAndDog.MethodCatAndDog(); //Уроки C# (C sharp) | #14 - Создание классов (Classes)
            //
            // TestClass.str = "creep"; //Вызов статической переменной без создание объекта класса
            // TestClass2.Test2(); //Вызов статического метода без создание объекта класса
            //
            // Addition(new[] { 1, 2 });
            // Addition(2, 3);
            // Addition();
            //
            // RegularExpression();
            //
            // Byke newByke = new Byke();
            // newByke.PrintExtensions();
            // newByke.byke.name = "Hamer";
            //
            // NewNewByke newNewByke = new NewNewByke(); //объекта newNewByke класса NewNewByke - наследует от IByke поведение интерфейса
            // newByke.Method1(newNewByke);
            //
            //FreePracties free = new FreePracties();
            //free.MethodBooks(free); //в MethodBooks положить объект free, который реализует поведение IBook
            //т.е. мы кладем туда метод void PrintBook()???

            //Console.WriteLine(Encoding.UTF8.GetBytes("БЩФzw!").Length);

            //PracticeFrequencyNgram();

            //NewMain();
            //CreateClass();

            //ulearn cоздание методов расширения https://ulearn.me/course/basicprogramming/Sozdanie_metodov_rasshireniya_06aa4e3e-c1f8-4895-ba1f-b7d5df22bb28
            //см. класс ToStringExtensions
            // var arg1 = "100500";
            // Console.Write(arg1.ToInt() + "42".ToInt());

            //DirectoryInfo, FileInfo https://ulearn.me/course/basicprogramming/DirectoryInfo_FileInfo_57b32e15-beed-4e75-9aee-dabc6af80bd7
            //DirectoryInfoAndFileInfoMethod();

            //ulearn Список директорий https://ulearn.me/course/basicprogramming/Spisok_direktoriy_24e64255-d0e2-418f-a86f-122d67117355
            //на ulearn падает
            // DirectoryInfo di = new DirectoryInfo(Environment.CurrentDirectory);
            // List<FileInfo> numbers = new List<FileInfo>();
            // foreach (var VARIABLE in di.GetFiles())
            // {
            //     numbers.Add(VARIABLE);
            // }
            // GetAlbumsClass.GetAlbums(numbers);

            //ulearn Рефакторинг статического класса https://ulearn.me/course/basicprogramming/Refaktoring_staticheskogo_klassa_a32d7a49-335a-4394-852d-10692e241efb
            // var filter = new SuperBeautyImageFilter();
            // filter.ImageName = "Paris.jpg";
            // filter.GaussianParameter = 0.4;
            // filter.Run();

            //ulearn Всем печать! https://ulearn.me/course/basicprogramming/Vsem_pechat__039b257e-d0f4-4bdd-99a2-66ade6485165
            // PrintClass.PrintExtensions(1, 2);
            // PrintClass.PrintExtensions("a", 'b');
            // PrintClass.PrintExtensions(1, "a");
            // PrintClass.PrintExtensions(true, "a", 1);

            Method82();
            
            
            Console.ReadKey();
        }
    }
}