using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace OCRoom_TP2
{
    class MainClass
    {
        
        public static void Main(string[] args)
        {
            /* // EXO 1
            Console.WriteLine(CalculSommeEntiers(1, 10)  + "attendu=11x10/2=55");
            Console.WriteLine(CalculSommeEntiers(1, 100) + "attendu=101x100/2=5050");
            Console.WriteLine(CalculSommeEntiers(1, 200) + "attendu=201x200/2=20100");

            // EXO 2
            List<double> myList = new List<double> { 1.0, 5.5, 9.9, 2.8, 9.6 };
            Console.WriteLine(CalculMoyenne(myList) + "attendu=5.76");

            List<string> myNumbers = new List<string> { "1.0", "5.5", "9.9", "2.8", "9.6" };
            double average = myNumbers.Average(num => Convert.ToDouble(num));
            Console.WriteLine(average + "attendu=5.76");

            List<double> myNumbers2 = new List<double> { 1.0, 5.5, 9.9, 2.8, 9.6 };
            double average2 = myNumbers2.Average(num => num);
            Console.WriteLine(average2 + "attendu=5.76");
            */
            // EXO 3
            Console.WriteLine(CalculSommeCommuns_A(1, 100) + "attendu=315");
            Console.WriteLine(CalculSommeCommuns_B(1, 100) + "attendu=315");
        }
        /*
        // METHODE EXO 1
        private static int CalculSommeEntiers(int min, int max)
        {
            int somme = 0;
            int i = min;

            while (i <= max)
            {
                somme = somme + i;
                i++;
            }

            return somme;
        } */
        /*
        // METHODE EXO 2
        private static double CalculMoyenne(List<double> list)
        {
            double somme = 0;
            foreach (var num in list)
            {
                somme = somme + num;
            }
            return somme / list.Count;
        } */

        // METHODE EXO 3
        private static int CalculSommeCommuns_A(int min, int max)
        {
            int somme = 0;
            List<int> list3 = new List<int>();
            List<int> list5 = new List<int>();

            for (int i = min; i < max; i++)
            {
                if (i % 3 == 0)
                {
                    list3.Add(i);
                }
                if (i % 5 == 0)
                {
                    list5.Add(i);
                }
            }

            foreach (int num in list3)
            {
                if (list5.Contains(num))
                {
                    somme = somme + num;
                }
            }
            return somme;
        }

        private static int CalculSommeCommuns_B(int min, int max)
        {
            int somme = 0;

            for (int i = 15; i < max; i += 15)
            {
                somme = somme + i;
            }
            return somme;
        }



    }


    // ENONCE des exercices
    /*
     * CREER TROIS METHODES
     * 
     * METHODE 1: 'CalculSommeEntiers'
     * Calculer la somme d'entiers consecutifs, arguments min et max;
     * 
     * METHODE 2: 'CalculMoyenne'
     * Calculer la moyenne des double d'une List
     * 
     * METHODE 3: 'CalculSommeCommuns'
     * 
     * 1/ entiers de 1 a 100 qui sont multiples de 3
     * 2/ entiers de 1 a 100 qui sont multiples de 5
     * 3/ somme des nombres communs aux deux listes
     * */


}
