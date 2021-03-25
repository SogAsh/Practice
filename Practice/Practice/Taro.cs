using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Taro
    {
        public enum Suits
        {
            Wands,
            Coins,
            Cups,
            Swords
        }

        public static string GetSuit(Suits suit)
        {
            return new[] { "жезлов", "монет", "кубков", "мечей" }[(int)suit];
        }
    }
}