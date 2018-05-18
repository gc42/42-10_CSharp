using System;
using System.Collections.Generic;
using System.Linq;

namespace OCRoom_TP3
{
    /*
     * ENONCE DE L'ACTIVITE 'Tirage du loto'
     * 1/ Creer un tableau de 7 elements
     * 2/ Alimenter en nombres aleatoires entre 1 et 49 inclus.
     *    Boucle qui tire un nombre qui n'a pas encore ete tire.
     * 3/ Afficher le contenu du tableau a l'aide d'une methode une fois le tirage termine.
     * */

    class MainClass
    {
        public static void Main()
        {
            // Init a Random
            Random rnd = new Random();

            // Generate and display 10 toss type Loto
            for (int i = 0; i < 10; i++)
            {
                int[] tab = RandomDraw(rnd);

                // 1/ tab.Select : Convert each 'p' value of the 'tab' array to string
                //    to transform 'int[] array' to 'string[] array'.
                // 2/ String.Join: Concatenete all string entries of a string[] array,
                //    here separated by a comma ','.
                string resultat = String.Join( ",", tab.Select( p => p.ToString() ) );

                Console.WriteLine("Le tirage de ce soir est: " + resultat + ".");
            }
        }

        // Draw seven random numbers from 1 to 49, return an array
        private static int[] RandomDraw(Random rnd)
        {
            List<int> tempDraw = new List<int>();

            for (int i = 1; i <= 7; i++)
            {
                bool find = false;

                while (!find)
                {
                    // Draw a random number
                    int tempToss = rnd.Next(1, 50);

                    // If not selected before, add it to the list. Else, draw again
                    if (!tempDraw.Contains(tempToss))
                    {
                        tempDraw.Add(tempToss);
                        find = true;
                    }
                    else
                        continue; 
                }
            }

            // Convert list to array and return it
            return tempDraw.ToArray();
        }
    }
}
