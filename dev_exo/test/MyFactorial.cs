using System;
namespace test
{
    public class MyFactorial
    {
        public int Factorial(int num)
        {
            if (num > 12)
                Console.WriteLine("Resultat trop grand. Saisissez une valeur entre 1 et 12");
            if (num == 1)
                return 1;
            else
            {
                return (Factorial(num - 1) * num);
            }
        }
    }
}
