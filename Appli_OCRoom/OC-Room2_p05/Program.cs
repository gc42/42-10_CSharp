using System;
using System.Collections.Generic;

namespace OCRoom2_p05
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            Voiture voitureNicolas = new Voiture { Vitesse = 10, Marque = "Volvo", Couleur = "Grise"};
            Voiture voitureJeremie = new Voiture { Vitesse = 10, Marque = "Volvo", Couleur = "Grise" };
            voitureNicolas.Couleur = "Bleue";
            voitureJeremie.Couleur = "Bleue";

            if (voitureJeremie.Equals(voitureNicolas))
            {
                Console.WriteLine("Les objets ont les memes proprietes.");
            }
            else
                Console.WriteLine("Les objets ont des caracteristiques differentes.");

            Voiture[] voitures = new Voiture[] {
                new Voiture {Vitesse = 100},
                new Voiture {Vitesse = 40},
                new Voiture {Vitesse = 10},
                new Voiture {Vitesse = 50},
                new Voiture {Vitesse = 60},
            };

            Array.Sort(voitures);

            foreach (var v in voitures)
            {
                Console.WriteLine(v.Vitesse);
            }
            */

            IVolant oiseau = new Oiseau { NombrePropulseurs = 2 };
            IVolant avion = new Avion { NombrePropulseurs = 4, NomDuCommandant = "Pirouette" };

            List<IVolant> volants = new List<IVolant> { oiseau, avion };
            foreach (IVolant volant in volants)
            {
                volant.Voler();
                Avion a = volant as Avion;
                if (a != null)
                {
                    Console.WriteLine("Pilote: " + a.NomDuCommandant);
                }
            }
        }
    }
}
