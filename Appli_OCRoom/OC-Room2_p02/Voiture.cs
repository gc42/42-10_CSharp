using System;
namespace OCRoom2_p02
{
    public class Voiture
    {
        public int Vitesse { get; set; }

        //public Voiture()
        //{
        //    Vitesse = 5;
        //}
        public Voiture() : this(15)
        {
        }

        public Voiture(int vitesseVoiture)
        {
            Vitesse = vitesseVoiture;
        }

        public void Rouler()
        {
            Console.WriteLine("Je roule a " + Vitesse + " km/h.");
        }
    }


}
