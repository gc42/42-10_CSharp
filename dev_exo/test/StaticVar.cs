using System;
namespace test
{
    public class StaticVar
    {
        public static int num = 0;

        public void Count()
        {
            num++;
        }

        public static int getNum()
        {
            return num;
        }
    }
}