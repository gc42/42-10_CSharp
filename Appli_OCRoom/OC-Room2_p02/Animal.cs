using System;
namespace OCRoom2_p02
{
    public class Animal
    {
        // Fields
        protected bool estVivant;
        protected string prenom;
        public int age;

        // Properties
        public int NombreDePattes { get; set; }

        // Consructor
        public Animal(string prenomAnimal)
        {
            prenom = prenomAnimal;
        }

        // Methods
        public void Respirer()
        {
            Console.WriteLine("Je suis {0} et je respire !", prenom);
        }

        public virtual void Cri()
        {
            Console.WriteLine("Le cri de la bete !");
        }

        public virtual void Manger()
        {
            Console.Write("Mettre les aliments dans la bouche, ");
            Console.Write("mastiquer, ");
            Console.Write("avaler, ");
            Console.WriteLine("...");
        }



    }
}
