using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.LINQ
{
    public class ReadListPoints
    {
        // public static List<Point> ParsePoints(IEnumerable<string> lines)
        // {
        //     return lines
        //         .Select(s => s.Split(' ')[0])
        //         .Where(d => d.Split(' ')[1])
        //         .ToList();
        //     //return lines.Where(x => x != "").Select(x => int.Parse(x)).ToArray();
        // }
        
        // public static void MainReadListPoints()
        // {
        //     // Функция тестирования ParsePoints
        //
        //     foreach (var point in ParsePoints(new[] { "1 -2", "-3 4", "0 2" }))
        //         Console.WriteLine(point.X + " " + point.Y);
        //     foreach (var point in ParsePoints(new List<string> { "+01 -0042" }))
        //         Console.WriteLine(point.X + " " + point.Y);
        // }

        public class Point
        {
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
            public int X, Y;
        }
    }
}