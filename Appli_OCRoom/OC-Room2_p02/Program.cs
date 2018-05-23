using System;
using System.Collections.Generic;

namespace OCRoom2_p02
{
    class MainClass
    {


        public static void Main(string[] args)
        {
            /*
            Voiture voitureNicolas = new Voiture(60);
            Voiture voitureJeremie = new Voiture();

            voitureJeremie.Rouler();
            voitureJeremie.Vitesse = 50;
			voitureJeremie.Rouler();

            voitureNicolas.Rouler();


            int a = 10;
            string chaine = a.ToString();
            chaine = "abc" + chaine;
            string chaineEnMajuscule = chaine.ToUpper();
            Console.WriteLine(chaineEnMajuscule);
            Console.WriteLine(chaineEnMajuscule.Length);
            */


            // Animaux
            List<Animal> animaux = new List<Animal>();

            Animal Miel = new Chien("Miel");
            Animal MonToutou = new Chien("MonToutou");
            Animal Idefix = new Chien("Idefix");
            Animal Midinette = new Chat("Midinette");
            Animal Machoupette = new Chat("Machoupette");

            animaux.Add(Miel);
            animaux.Add(MonToutou);
            animaux.Add(Idefix);
            animaux.Add(Midinette);
            animaux.Add(Machoupette);

            foreach (Animal animal in animaux)
            {
                //animal.Respirer();
                //animal.Cri();
                Console.WriteLine(animal);
                animal.Manger();
            }


        }
    }
}
