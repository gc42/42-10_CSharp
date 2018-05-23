using System;
using System.Globalization;
namespace test
{
    public class TableTop : Rectangle, IPaintCost
    {
        // Fields

        // Constructor initialise base fields
        public TableTop(double l, double w) : base(l, w)// et ne fait rien d'autre
        {
        }

        // Getters
        public double GetCost(double aera)
        {
            return aera * 70;
        }


		public override double GetArea()
		{
            Console.WriteLine("TableTop class area :");
            return lenght * width;
		}
		// Methods
		public new void Display()
        {
            base.Display();
            Console.WriteLine("Cost   : {0}", GetCost(GetArea()).ToString("C2", CultureInfo.CreateSpecificCulture("fr-FR")));
        }
    }//end class TableTop:Rectangle
}
