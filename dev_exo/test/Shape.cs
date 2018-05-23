using System;
namespace test
{
    public class Shape
    {
        // Fields
        protected double lenght;
        protected double width;

        // Constructor
        public Shape( double l = 0.0, double w = 0.0)
        {
            lenght = l;
            width  = w;
        }

        // Virtual method
        public virtual double GetArea()
        {
            Console.WriteLine("Shape class area :");
            return 0.0;
        }
    }
}
