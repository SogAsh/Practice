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
            //if (suit == Suits.Wands) return "жезлов";
            //else if (suit == Suits.Coins) return "монет";
            //else if (suit == Suits.Cups) return "кубков";
            //else return "мечей";

            /*
             * enum можно конвертировать в int!
               (int)Suits.Wands равен нулю, (int)Suits.Coins — единице и так далее.
             */

            return new[] { "жезлов", "монет", "кубков", "мечей" }[(int)suit];

        }
    }
}
