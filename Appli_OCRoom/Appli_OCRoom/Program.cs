using System;
using System.Collections.Generic;

namespace Appli_OCRoom
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

            // Differentes valeurs pour tester
            PrintResult(user, time, dayValue);

            PrintResult(user, time, 1);
            PrintResult(user, time, 7);
            PrintResult(user, 12, 3);
            PrintResult(user, 19, 4);
            PrintResult(user, 19, 5);
        }

        private static void PrintResult(string user, int time, int dayValue)
        {
            Console.Write("(" + time + ":" + dayValue+ ") ");

            if ( (1 <= dayValue && dayValue <= 5) && (9 <= time && time <= 18) )
            {
                Console.Write("Bonjour ");
            }
            else if ( (1 <= dayValue && dayValue <= 4) && ( (18 < time && time <= 23) || (0 <= time && time < 9) ) )
            {
                Console.Write("Bonsoir ");
            }
            else
            {
                Console.Write("Passe un bon week-end ");
            }

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
