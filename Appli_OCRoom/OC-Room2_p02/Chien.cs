using System;
namespace OCRoom2_p02
{
    public class Chien : Animal
    {
        // Constructor
        public Chien(string prenomDuChien) : base(prenomDuChien)
        {
        }

        // Methods
        public override void Cri()
        {
            Console.WriteLine("Wouaf !");
        }

        public void Vieillir()
        {
            age++;
        }

        public void Naissance()
        {
            age = 0;
            estVivant = true;
        }

		public override void Manger()
		{
            Console.WriteLine("Reclamer a manger au maitre");
            base.Manger();
            Console.WriteLine("Remuer la queue");
		}

		public override string ToString()
		{
            return "Je suis un chien et je m'appelle " + base.prenom;
		}
	}
}
