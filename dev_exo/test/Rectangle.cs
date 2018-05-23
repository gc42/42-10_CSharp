using System;
namespace test
{
    public class Rectangle : Shape
    {
        // Fields

        // Constructor + Parameters
        public Rectangle(double l, double w) : base(l, w)
        {
        }

        // Getters
        public override double GetArea()
        {
            Console.WriteLine("Rectangle class area :");
            return lenght * width;
        }

        // Methods
        public void Display()
        {
            Console.WriteLine("Lenght : {0} ml", lenght);
            Console.WriteLine("Width  : {0} ml", width);
            Console.WriteLine("Area   : {0} m2", GetArea());
        }
    }//end class Rectangle
}
