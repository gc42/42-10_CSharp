using System;

namespace OCRoom_17Inputs
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*// 1/
            Console.WriteLine("Saisissez une phrase et validez avec la touche \"Entree\"");
            string saisie = Console.ReadLine();
            Console.WriteLine("Vous avez saisi: " + saisie);
            */

            // 2/
            bool        ageIsValid  = false;
            int         age         = -1;

            while (!ageIsValid)
            {
                Console.WriteLine("Tapez sur la touche \"clear\", puis \"O\" pour commencer...");
                ConsoleKeyInfo saisieClear = Console.ReadKey(true);
                Console.WriteLine(saisieClear.Key.ToString() + "\n");

                if (saisieClear.Key == ConsoleKey.O)
                    Console.WriteLine("On continue...");
                else
                {
					Console.WriteLine("On s'arrete.");
                    return;
                }
                

                Console.WriteLine("Veuillez saisir votre age:");
                string saisie2 = Console.ReadLine();
                if (int.TryParse(saisie2, out age))
                    ageIsValid = true;
                else
                {
                    ageIsValid = false;
                    Console.WriteLine("L'age saisi est incorrect...");
                }
            }
            Console.WriteLine("Votre age est de : " + age + "ans.");
        }
    }
}
