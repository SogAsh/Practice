using System;

namespace Practice.OOP
{
    public static class ToStringExtensions
    {
        //Создание методов расширения https://ulearn.me/course/basicprogramming/Sozdanie_metodov_rasshireniya_06aa4e3e-c1f8-4895-ba1f-b7d5df22bb28
        public static int ToInt(this String val)
        {
            var x = Int32.Parse(val);
            return x;
        }
    }
}