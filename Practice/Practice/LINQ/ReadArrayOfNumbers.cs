using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using NUnit.Framework;

namespace Practice.LINQ
{
    //Чтение массива чисел
    //https://ulearn.me/course/linq/Chtenie_massiva_chisel_cba7bc68-f1b9-46b1-93d4-49ac113a1d02?autoplay=true
    public class ReadArrayOfNumbers
    {
        public static int[] ParseNumbers(IEnumerable<string> lines)
        {
            // var str = lines.Where(x => x != "");
            // var str2 = str.Select(x => int.Parse(x));
            // var str3 = str2.ToArray();
            //
            // return str3;
            
            //или так
            return lines.Where(x => x != "").Select(x => int.Parse(x)).ToArray();
        }

        public static void CheckoutException()
        {
            var people = new[]{"Pavel Egorov", "Yuriy Okulovskiy", 
                "Alexandr Denisov", "Ivan Sorokin", 
                "Dasha Zubova", "Irina Gess"};
			
            var names = people.Select(fullname => fullname.Split(' ')[0]); //берем первое значение из строки (имя)
            var names2 = people.Select(fullname => fullname.Split(' ')); //берем оба значения из строки (иия + фамилия)
			
            var girls = names.Where(name => name[name.Length - 1] == 'a');

            Assert.That(girls, Is.EqualTo(new[] {"Dasha", "Irina"}));
        }

        public static void MainReadArrayOfNumbers()
        {
            foreach (var num in ParseNumbers(new[] { "-0", "+0000" }))
                Console.WriteLine(num);
            foreach (var num in ParseNumbers(new List<string> { "1", "", "-03", "0" }))
                Console.WriteLine(num);
        }

    }
}