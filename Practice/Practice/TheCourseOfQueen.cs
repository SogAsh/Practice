using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class TheCourseOfQueen
    {
        /*                                                 dx     dy
            *   TheCourseOfQueen.TestMove("a1", "d4");    1-4=3  1-4=3 dx == dy = true
                TheCourseOfQueen.TestMove("f4", "e7");    6-5=1  4-7=3 false

                TheCourseOfQueen.TestMove("a1", "b1");    1-2=1  1-1=0 true
                TheCourseOfQueen.TestMove("a1", "c2");    1-3=2  1-2=1 false 
                TheCourseOfQueen.TestMove("a1", "d3");    1-4=3  1-3=2 false

                TheCourseOfQueen.TestMove("a1", "a4");    1-1=0  1-4=3 true
                TheCourseOfQueen.TestMove("a1", "a1");    1-1=0  1-1=0 false
         */
        public static void TestMove(string from, string to)
        {
            Console.WriteLine("{0}-{1} {2}", from, to, IsCorrectMove(from, to));
        }

        public static bool IsCorrectMove(string from, string to)
        {
            var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали 
            var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали

            if (dx == 0 && dy ==0)
            {
                return false;
            }

            if (dx == dy || dx * dy == 0)
            {
                return true;
            }


            return false;
        }
    }
}
