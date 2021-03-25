using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class RobotManage
    {
        public static bool ShouldFire(bool enemyInFront, string enemyName, int robotHealth)
        {
            var shouldFire = true;

            if (enemyInFront)
            {
                if (enemyName != "boss") return true;
                if (robotHealth < 50) shouldFire = false;
                if (robotHealth > 100) shouldFire = true;
            }
            else return false;

            Console.WriteLine(shouldFire);
            return shouldFire;
        }

        public static bool ShouldFire2(bool enemyInFront, string enemyName, int robotHealth)
        {

            return enemyInFront && (enemyName == "boss") && (robotHealth > 100);

        }
    }
}