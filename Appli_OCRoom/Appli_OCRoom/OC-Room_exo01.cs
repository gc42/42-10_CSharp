
/*using System;
using System.Collections.Generic;

namespace Appli_OCRoom
{
    enum Jours
    {
        Lundi,
        Mardi,
        Mercredi,
        Jeudi,
        Vendredi,
        Samedi,
        Dimanche
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            // TABLEAU
            string[] jours = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            Console.WriteLine("jour {0}\n", jours[3]);

            PrintTab(jours);
            Array.Sort(jours);
            PrintTab(jours);

            //LISTES
            List<string> moisA = new List<string>(); // Creation de la liste
            moisA.Add("Janvier");
            moisA.Add("Fevrier");

            // LISTES ecriture simplifiee
            List<string> moisB = new List<string> { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Decembre" }; // Creation de la liste
            foreach (string mois in moisB)
            {
                Console.Write(mois + ", ");
            }
            Console.WriteLine(string.Empty);

            // utilise une METHODE
            DireBonjour("Ambre", 11);
            DireBonjour("Max", 21);

            Console.WriteLine("Hypothenuse = {0:F2}", LongueurHypothenuse(3, 4.5));

            //ENUM
            Jours jourDeLaSemaine = Jours.Dimanche;
            Console.WriteLine(jourDeLaSemaine);
            if (jourDeLaSemaine == Jours.Samedi || jourDeLaSemaine == Jours.Dimanche)
                Console.WriteLine("Bon week-end!!\n");

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(System.Environment.UserName);


        }







        private static void PrintTab(string[] tableau)
        {
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.Write(tableau[i]);
                if (i < tableau.Length - 1)
                    Console.Write(", ");
                else
                    Console.WriteLine(string.Empty);
            }
        }

        public static void DireBonjour(string prenom, int age)
        {
            Console.WriteLine("Bonjour " + prenom);
            Console.WriteLine("Vous avez " + age + " ans");
        }

        public static double LongueurHypothenuse(double a, double b)
        {
            double sommeDesCarres = a * a + b * b;
            double resultat = Math.Sqrt(sommeDesCarres);
            return resultat;
        }
    }
}
*/