using System;

namespace Practice.DataIntegrity
{
    public class Vector
    {
        public double X;
        public double Y;
        private double length;

        public double Length
        {
            get
            {
                var x2 = Math.Pow(X, 2);
                var y2 = Math.Pow(Y, 2);
                var res = x2 + y2;
                return length = Math.Sqrt(res);
            }
        }

        public Vector(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1}) with length: {2}", X, Y, Length);
        }
        
        public static void Check()
        {
            Vector vector = new Vector(3, 4);
            Console.WriteLine(vector.ToString());

            vector.X = 0;
            vector.Y = -1;
            Console.WriteLine(vector.ToString());

            vector = new Vector(9, 40);
            Console.WriteLine(vector.ToString());
	
            Console.WriteLine(new Vector(0, 0).ToString());
        }
    }
}