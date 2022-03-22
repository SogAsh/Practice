using System;
using System.Globalization;

namespace Practice.DataIntegrity
{
    public class Ratio
    {
        public readonly double Numerator; //числитель
        public readonly double Denominator; //знаменатель
        private double value;

        public double Value
        {
            get
            {
                if (Denominator <= 0)
                    throw new ArgumentException();
                return value = Numerator / Denominator;
            }
        } //значение дроби Numerator / Denominator

        public Ratio(int num, int den)
        {
            Numerator = num;
            Denominator = den;
        }

        public static void Check(int num, int den)
        {
            var ratio = new Ratio(num, den);

            Console.WriteLine("{0}/{1} = {2}",
                ratio.Numerator, ratio.Denominator,
                ratio.Value.ToString(CultureInfo.InvariantCulture));
        }
    }
}