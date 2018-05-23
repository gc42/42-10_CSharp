using System;
namespace test
{
    public class Caller
    {
        public void CallArea(Shape sh)
        {
            double a = sh.GetArea();
            Console.WriteLine("Area : {0}", a);
        }
    }
}
