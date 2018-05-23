using System;
namespace test
{
    public class Triangle : Shape
    {
        public Triangle( double l = 0, double w = 0) : base(l,w)
        {
        }

		public override double GetArea()
		{
            Console.WriteLine("Triangle class area :");
            return (lenght * width / 2);
		}
	}
}
