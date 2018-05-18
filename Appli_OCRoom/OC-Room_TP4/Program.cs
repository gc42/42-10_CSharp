using System;

namespace OCRoom_TP4
{
    /* TP n4 REGLES DU JEU du plus ou du moins */
    /* Deviner un nombre aleatoire.
     * A chaque saisie du joueur, le jeu repond par c'est plus ou c'est moins.
     * Lorsqu'on trouve, le jeu indique en combien de coups.
     * */

    class MainClass
    {
        public static void Main(string[] args)
        {
        Replay:
            int     valueToFind     = new Random().Next(1, 101);
            bool    isFind          = false;
            int     number          = -1;
            int     count           = 0;

            Console.WriteLine("L'ordinateur a choisi un nombre. Essayez de le trouver!");

            while (!isFind)
            {
                Console.Write("Entrez un nombre entre 1 et 100: ");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number >= 1 && number <= 100)
                    {
                        if (number == valueToFind)
                            isFind = true;
                        else
                        {
                            if (number < valueToFind)
                                Console.WriteLine("C'est plus !");
                            else
                                Console.WriteLine("C'est moins !");
                        }   
                        count++;
                    }
                    else
                        Console.WriteLine("Le nombre saisi est en dehors des bornes.");
                }
                else
                    Console.WriteLine("Valeur eronnee :  vous devez saisir un nombre entier.");
            }

            Console.Write("Trouve en " + count + " coup<s>. Rejouer ? Oui/Non :");
            ConsoleKeyInfo rejouer = Console.ReadKey(false);
            Console.WriteLine("\n");

            if ( rejouer.Key == ConsoleKey.O)
            {
                Console.Clear();
                goto Replay;
            }
            else
                Console.WriteLine("Merci d'avoir joue. A une prochaine fois !!");
        }
    }
}
