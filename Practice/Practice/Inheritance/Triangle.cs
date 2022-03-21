namespace Practice.Inheritance
{
    public class Triangle
    {
        public PointTriangle A { get; set; }
        public PointTriangle B { get; set; }
        public PointTriangle C { get; set; }
        
        public override string ToString()
        {
            return string.Format("({0}) ({1}) ({2})", A, B, C);
        }
    }
    
    public class PointTriangle
    {
        public double X;
        public double Y;
        
        public override string ToString()
        {
            return string.Format("{0} {1}", X, Y);
        }
    }
}