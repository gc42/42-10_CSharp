using System;

namespace OCRoom_16Cast
{
    enum Jours
    {
        Lundi = 1,
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
            // 1/ Valeurs d'un ENUM
            int valeur = (int)Jours.Lundi;
            Console.WriteLine(valeur);
            Console.WriteLine(Jours.Lundi);

            // 2/ Test de conversion string vers int
            string chaineAge = "ab20cd";
            int age;

            if (int.TryParse(chaineAge, out age))
            {
                Console.WriteLine("La conversion est possible, age vaut : " + age);
            }
            else
            {
                Console.WriteLine("Conversion impossible !");
            }

            // 3/ Test de conversion string vers int avec Convert.ToInt32()
            string chaineAge2 = "20";
            int age2 = Convert.ToInt32(chaineAge2);
            Console.WriteLine(age2);
            Console.WriteLine(chaineAge2);

            chaineAge2 = "vingt ans";
            age2 = Convert.ToInt32(chaineAge2);
            Console.WriteLine(age2);
            Console.WriteLine(chaineAge2);
        }
    }
}
