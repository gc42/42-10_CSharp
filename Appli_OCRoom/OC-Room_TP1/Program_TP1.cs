using System;
using System.Globalization;
using System.Collections.Generic;

namespace OCRoom_TP1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string>    days     = new List<string> { "none", "Monday", "Tuesday", "Wednesday", "Thursday", "Fryday", "Saterday", "Sunday" }; // Creation de la liste
            string          user     = System.Environment.UserName;
            int             time     = DateTime.Now.Hour;
            int             dayValue = days.IndexOf(DateTime.Now.ToString("dddd"));

            Console.Write("Actually: " + DateTime.Now.Hour + "h, " + dayValue + "(" + DateTime.Now.ToString("dddd") + ")");
            Console.WriteLine(DateTime.Now.DayOfWeek);


            // Differentes valeurs pour tester =================================
            PrintResult(user, time, dayValue, "jour");
            PrintResult(user, time, 1,  "jour");
            PrintResult(user, time, 7,  "week");
            PrintResult(user, 12,   3,  "jour");
            PrintResult(user, 19,   4,  "soir");
            PrintResult(user, 19,   5,  "week");


            // TEST Boucles for, while, foreach etc ============================
            // Test 1
            for (int i = 1; i < days.Count; i++)
            {
                Console.Write(days[i] + ", ");
            }
            Console.WriteLine(string.Empty);

            // Test 2
            int y = 0;
            while (++y<days.Count)
            {
                Console.Write(days[y] + ", ");
            }
            Console.WriteLine(string.Empty);

            // Test 3
            y = 0;
            bool trouve = false;
            while (y<days.Count && !trouve)
            {
                string valeur = days[y];
                if (valeur == "Fryday")
                {
                    trouve = true;
                    break;
                }
                else
                    y++;
            }
            if (!trouve)
                Console.WriteLine("Valeur non trouvee");
            else
                Console.WriteLine("Trouve valeur a l'indice " + y);
            Console.WriteLine(string.Empty);

            // Test 4
            foreach (var day in days)
            {
                Console.Write(day + ", ");
            }
            Console.WriteLine(string.Empty);



            // TEST Formatage des nombres ======================================
            float number = 1234.56789f;
            Console.WriteLine("Exemple d'arrondi(N1):\t {0,12:N1}", number);
            Console.WriteLine("Exemple d'arrondi(N2):\t {0:N2}", number);
            Console.WriteLine("Exemple d'arrondi(G2):\t {0:G2}", number);
            Console.WriteLine("Exemple d'arrondi(P2):\t {0:P2}", number);
            Console.WriteLine("Exemple d'arrondi(P2):\t {0}", number.ToString("P2", CultureInfo.CreateSpecificCulture("fr-FR")));
            Console.WriteLine("Exemple d'arrondi(F2):\t {0:F2}", number);
            //Console.WriteLine("Exemple d'arrondi(D2):\t {0:D2}", number); // Ne prend que des entiers, pas des double
            Console.WriteLine("Exemple d'arrondi(C2):\t {0:C2}", number);
            Console.WriteLine("Exemple d'arrondi(C2):\t {0}", number.ToString("C2", CultureInfo.CreateSpecificCulture("fr-FR")));
        }

        private static void PrintResult(string user, int time, int dayValue, string attendu)
        {
            Console.Write("(" + time + ":" + dayValue + ") " + "[" + attendu + "] :");

            if ( (1 <= dayValue && dayValue <= 5) && (9 <= time && time <= 18) )
                Console.Write("Bonjour ");
            else if ( (1 <= dayValue && dayValue <= 4) && ( (18 < time && time <= 23) || (0 <= time && time < 9) ) )
                Console.Write("Bonsoir ");
            else
                Console.Write("Passe un bon week-end ");

            Console.WriteLine(user + ".");
        }

    }
    
    // Enonce du probleme
    /*
     * Bonjour XXX pour la tranche horaire 9h <-> 18h, les lundi, mardi, mercredi, jeudi et vendredi
     * Bonsoir XXX pour la tranche horaire 18h <-> 9h, les lundi, mardi, mercredi, jeudi
     * Bon week-end XXX pour la tranche horaire vendredi 18h <-> lundi 9h
     * */
        
}