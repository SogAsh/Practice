using System;
using System.Globalization;

namespace Practice.OOP
{
    public class SuperBeautyImageFilter
    {
        public string ImageName;
        public double GaussianParameter;
        public void Run()
        {
            Console.WriteLine("Processing {0} with parameter {1}", 
                ImageName, 
                GaussianParameter.ToString(CultureInfo.InvariantCulture));
            //do something useful
        }
    }
}