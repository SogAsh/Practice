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

        public static void Method101()
        {
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;

            foreach (var i in array)
            {

            }


            foreach (var t in array)
            {
                Console.WriteLine(t);
            }
        }


        public static void Method100()
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
            // https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/boolean-logical-operators#logical-and-operator-
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

            //Byke newByke = new Byke();
            //newByke.Print();
            //newByke.byke.name = "Hamer";

            //NewNewByke newNewByke = new NewNewByke(); //объекта newNewByke класса NewNewByke - наследует от IByke поведение интерфейса
            //newByke.Method1(newNewByke);


            //FreePracties free = new FreePracties();
            //free.MethodBooks(free); //в MethodBooks положить объект free, который реализует поведение IBook
            //т.е. мы кладем туда метод void PrintBook()???


            //ULEARN -----------------------------------------------------------------------------------------------------------------------------------

            //static void Method14() //Ошибки преобразования типов
            //{
            //    double pi = Math.PI;
            //    float newPi = (float)pi;
            //    long tenThousand = 10000L;
            //    double tenThousandPi = newPi * tenThousand;
            //    int roundedTenThousandPi = (int)Math.Round(tenThousandPi); //округление до ближайшего целого числа
            //    int integerPartOfTenThousandPi = (int)tenThousandPi;
            //    Console.WriteLine(integerPartOfTenThousandPi);
            //    Console.WriteLine(roundedTenThousandPi);
            //}

            //Method14();

            //static void Method15() //Биткоины в массы!
            //{
            //    double amount = 1.11;
            //    int peopleCount = 60;
            //    int totalMoney = (int)Math.Round(amount * peopleCount); //округление до ближайшего целого числа
            //    Console.WriteLine(totalMoney);
            //}

            //Method15();

            //static void Method16() //Преобразование строки в число
            //{
            //    string doubleNumber = "894376.243643";
            //    //double number = double.Parse(doubleNumber); работает в старой студии
            //    //Console.WriteLine(number + 1);
            //}

            //Method16();

            //static void Method17() //Использование var
            //{
            //    double a = 5;
            //    a += 0.5;
            //    Console.WriteLine(a);
            //}

            //Method17();


            //ulearn Главный вопрос Вселенной https://ulearn.me/course/basicprogramming/Glavnyy_vopros_Vselennoy_d5b59540-410f-4f6d-8f04-b5613e264bd5
            //MainQuestionUniverse.NewPrint(MainQuestionUniverse.GetSquare(42));

            //static string Method18(int a, int b, int c)
            //{
            //    if ((a < 0) || (a == 0 && b != 0))
            //        return "Impossible";
            //    else
            //    {
            //        if (a == 0 && b == 0)
            //            return c.ToString();
            //        else
            //            return (-b / (2 * a)).ToString();
            //    }
            //}

            //Console.WriteLine(Method18(1, 2, 3));
            //Console.WriteLine(Method18(0, 3, 2));
            //Console.WriteLine(Method18(1, -2, -3));
            //Console.WriteLine(Method18(5, 2, 1));
            //Console.WriteLine(Method18(4, 3, 2));
            //Console.WriteLine(Method18(0, 4, 5));

            // А в этих случаях решение существует:
            //Console.WriteLine(Method18(0, 0, 2) != "Impossible");
            //Console.WriteLine(Method18(0, 0, 0) != "Impossible");

            //--------------------------------------------------------------------------------------------------------------------------------------

            //ulearn Добрый работодатель https://ulearn.me/course/basicprogramming/Dobryy_rabotodatel__f6559650-b3af-4e5e-be84-941fb21bc2ac
            //Console.WriteLine(KindEmploer.GetGreetingMessage("Student", 10.01));
            //Console.WriteLine(KindEmploer.GetGreetingMessage("Bill Gates", 10000000.5));
            //Console.WriteLine(KindEmploer.GetGreetingMessage("Steve Jobs", 1));

            //ulearn Разыскиваются методы! https://ulearn.me/Course/BasicProgramming/Razyskivayutsya_metody__d8578c7f-d7e2-4ce5-a3be-e6e32d9ac63e
            //Console.WriteLine(MethodsWanted.GetLastHalf("I love CSharp!"));
            //Console.WriteLine(MethodsWanted.GetLastHalf("1234567890"));
            //Console.WriteLine(MethodsWanted.GetLastHalf("до ре ми фа соль ля си"));

            //ulearn Високосный год https://ulearn.me/course/basicprogramming/Visokosnyy_god_4c161b1e-2637-447b-adfd-14647bf659ad?autoplay=true
            //LeapYear LeapYear = new LeapYear();
            //Console.WriteLine(LeapYear.IsLeapYear(1700));
            //Console.WriteLine(LeapYear.IsLeapYear(1999));
            //Console.WriteLine(LeapYear.IsLeapYear(8992));
            //Console.WriteLine(LeapYear.IsLeapYear(1));
            //Console.WriteLine(LeapYear.IsLeapYear(14));
            //Console.WriteLine(LeapYear.IsLeapYear(400));
            //Console.WriteLine(LeapYear.IsLeapYear(600));
            //Console.WriteLine(LeapYear.IsLeapYear(3200));

            //ulearn Сравнение чисел с плавающей точкой https://ulearn.me/course/basicprogramming/Sravnenie_chisel_s_plavayushchey_tochkoy_1e844dc5-c026-4acc-b28f-086a2e7c6f8e
            // в бинарном виде 0.1 представляется бесконечной дробью 0.00011001100..., в типах данных float и double хранится только начало этой дроби, поэтому число 0.1 представляется с погрешностью. 
            //double x = 1.0 / 10;  double sum = 0;
            //for (int i = 0; i < 10; i++) sum += x;
            //Console.WriteLine(Math.Abs(sum - 1) < 1e-9); //Здесь мы проверяем, что числа равны не в точности, но что модуль их разности меньше некоторого маленького числа. Всегда используйте такую конструкцию при сравнении чисел с плавающей точкой.

            //ulearn Ход ферзя https://ulearn.me/course/basicprogramming/Khod_ferzya_eb11dfb6-5629-4d13-819b-6411b9f93df6?autoplay=true
            //TheCourseOfQueen TheCourseOfQueen = new TheCourseOfQueen();
            //TheCourseOfQueen.TestMove("a1", "d4");
            //TheCourseOfQueen.TestMove("f4", "e7");
            //TheCourseOfQueen.TestMove("a1", "a4");
            //TheCourseOfQueen.TestMove("a1", "a1");

            //ulearn Среднее трех https://ulearn.me/course/basicprogramming/Srednee_trekh_937c4e64-7144-4f52-a75d-4bdc95bbde72?autoplay=true
            //AverageOfThree AverageOfThree = new AverageOfThree();
            //Console.WriteLine(AverageOfThree.MiddleOf(5, 0, 100)); // => 5
            //Console.WriteLine(AverageOfThree.MiddleOf(12, 12, 11)); // => 12
            //Console.WriteLine(AverageOfThree.MiddleOf(1, 1, 1)); // => 1
            //Console.WriteLine(AverageOfThree.MiddleOf(2, 3, 2)); //2
            //Console.WriteLine(AverageOfThree.MiddleOf(8, 8, 8)); //8
            //Console.WriteLine(AverageOfThree.MiddleOf(5, 0, 1)); //1
            //Console.WriteLine(AverageOfThree.MiddleOf(47, 15, 19)); //19
            //Console.WriteLine(AverageOfThree.MiddleOf(11, 97, 97)); //97

            //ulearn Управление роботом https://ulearn.me/course/basicprogramming/Upravlenie_robotom_50ac4fc7-a6e1-4c4e-8c61-ecc75aeb912e
            //RobotManage RobotManage = new RobotManage();
            //RobotManage.ShouldFire(true, "boss", 70);
            //RobotManage.ShouldFire2(true, "boss", 70);

            //ulearn В поисках степени двойки https://ulearn.me/course/basicprogramming/V_poiskakh_stepeni_dvoyki_4158c9a6-a71d-4015-a283-def12be0055e
            //Console.WriteLine(InSearchOfThePowerOfTwo.GetMinPowerOfTwoLargerThan(2)); // => 4
            //Console.WriteLine(InSearchOfThePowerOfTwo.GetMinPowerOfTwoLargerThan(15)); // => 16
            //Console.WriteLine(InSearchOfThePowerOfTwo.GetMinPowerOfTwoLargerThan(-2)); // => 1
            //Console.WriteLine(InSearchOfThePowerOfTwo.GetMinPowerOfTwoLargerThan(-100));
            //Console.WriteLine(InSearchOfThePowerOfTwo.GetMinPowerOfTwoLargerThan(100));

            //ulearn Убрать пробелы https://ulearn.me/course/basicprogramming/Ubrat_probely_9a15ebd5-0616-4a18-b842-e63e2c3c21fa
            //Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces("a"));
            //Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces(" b"));
            //Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces(" cd"));
            //Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces(" efg"));
            //Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces(" text"));
            //Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces(" two words"));
            //Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces("  two spaces"));
            //Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces("	tabs"));
            //Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces("		two	tabs"));
            //Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces("                             many spaces"));
            //Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces("               "));
            //Console.WriteLine(DeleteWhitespaces.RemoveStartSpaces("\n\r line breaks are spaces too"));

            //ulearn Рамочка https://ulearn.me/course/basicprogramming/Ramochka_6923aa65-95e0-4b5e-a98d-b286fd0b2153
            //Frame.WriteTextWithBorder("Menu:");
            //Frame.WriteTextWithBorder("");
            //Frame.WriteTextWithBorder(" ");
            //Frame.WriteTextWithBorder("Game Over!");
            //Frame.WriteTextWithBorder("Select level:");

            //ulearn Шахматная доска https://ulearn.me/course/basicprogramming/_Shakhmatnaya_doska_8e561342-9f4b-411d-bb9b-741a3677f696
            //Chess.WriteBoard(8);
            //Chess.WriteBoard(1);
            //Chess.WriteBoard(2);
            //Chess.WriteBoard(3);
            //Chess.WriteBoard(10);

            //ulearn Четный массив https://ulearn.me/course/basicprogramming/Chetnyy_massiv_ceb81eac-069c-4d5d-87b7-ebd9b140e143?autoplay=true
            //BlackArray.GetFirstEvenNumbers(3);
            //BlackArray.GetFirstEvenNumbers(2);
            //BlackArray.GetFirstEvenNumbers(4);

            //ulearn Индекс максимума https://ulearn.me/course/basicprogramming/Indeks_maksimuma_043015a0-0b28-4435-8079-21e4ca8e6526
            //double[] a = { 1, 9, 9, 8, 9, 2, 2 };
            //double[] b = { 1, 2, 46, 14, 64, 64 };
            //double[] d = { 1, 2, 3 };
            //Console.WriteLine(MaximumIndex.MaxIndex(a));
            //Console.WriteLine(MaximumIndex.MaxIndex(b));
            //Console.WriteLine(MaximumIndex.MaxIndex(d));

            //ulearn Подсчет https://ulearn.me/course/basicprogramming/Podschet_9eb1a5c2-135d-49a5-a922-0f3f91566080
            //int[] a = { 1, 2, 1, 1 };
            //Console.WriteLine(Count.GetElementCount(a, 1));

            //ulearn Поиск массива в массиве https://ulearn.me/course/basicprogramming/Poisk_massiva_v_massive_df8d1ca7-9aab-4816-8047-a834c6ca64d4
            //int[] array = { 1, 6, 2, 3, 4, 3, 4 };
            //int[] subarray = { 3, 4, 9 };
            //SearchArrayIntoArray.FindSubarrayStartIndex(array, subarray);

            //ulearn Карты Таро https://ulearn.me/course/basicprogramming/Karty_Taro_26c265ba-ea70-4aa9-bf6b-5c215576a3ab
            //Console.WriteLine(Taro.GetSuit(Taro.Suits.Wands));
            //Console.WriteLine(Taro.GetSuit(Taro.Suits.Coins));
            //Console.WriteLine(Taro.GetSuit(Taro.Suits.Cups));
            //Console.WriteLine(Taro.GetSuit(Taro.Suits.Swords));

            //FluentAPI Более сложный случай https://ulearn.me/course/cs2/Bolee_slozhnyy_sluchay_df079b25-8952-4d6f-976b-f92b17c93005
            //var spectacle = new Spectacle()
            //    .Say("Привет мир!")
            //    .Delay(TimeSpan.FromSeconds(1))
            //    .UntilKeyPressed(s =>
            //        s.Say("тра-ля-ля")
            //            .Delay(TimeSpan.FromMilliseconds(500))
            //            .Say("тру-лю-лю")
            //            .Delay(TimeSpan.FromMilliseconds(500))
            //    )
            //    .Say("Пока-пока!");

            //spectacle.Play();

            //FluentAPI Расширяемость Fluent-Интерфейсов https://ulearn.me/course/cs2/Rasshiryaemost_Fluent_Interfeysov_30c4a153-5510-4015-ab90-98e259b8da7f
            //var newSpectacle = new NewSpectacle()
            //    .Say("Привет мир!")
            //    .Delay(TimeSpan.FromSeconds(1))
            //    .UntilKeyPressed(s =>
            //        s.TypeText("тра-ля-ля")
            //        .TypeText("тру-лю-лю")
            //    )
            //    .Say("Пока-пока!");

            //newSpectacle.Play();

            //ulearn Null или не Null? https://ulearn.me/course/basicprogramming/Null_ili_ne_Null__05581efc-0377-438e-b6c6-90778d3c8922
            //Console.WriteLine(NullOrNotNull.CheckFirstElement(null));
            //Console.WriteLine(NullOrNotNull.CheckFirstElement(new int[0]));
            //Console.WriteLine(NullOrNotNull.CheckFirstElement(new[] { 1 }));
            //Console.WriteLine(NullOrNotNull.CheckFirstElement(new[] { 0 }));

            //ulearn Возвести массив в степень https://ulearn.me/course/basicprogramming/Vozvesti_massiv_v_stepen__e3e45ec7-7bd0-4284-8ca1-0fbcb2fa0c21
            var arrayToPower = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Метод PrintArray уже написан за вас
            RaiseAnArayToADegree.PrintArray(GetPoweredArray(arrayToPower, 1));

            // если вы будете менять исходный массив, то следующие два теста сработают неверно:
            RaiseAnArayToADegree.PrintArray(GetPoweredArray(arrayToPower, 2));
            RaiseAnArayToADegree.PrintArray(GetPoweredArray(arrayToPower, 3));

            // не забывайте про частные случаи:
            RaiseAnArayToADegree.PrintArray(GetPoweredArray(new int[0], 1));
            RaiseAnArayToADegree.PrintArray(GetPoweredArray(new[] { 42 }, 0));

            Console.ReadKey();
        }
    }
}