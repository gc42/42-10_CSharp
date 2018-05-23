using System;
namespace OCRoom2_p05
{
    public class Voiture : IComparable  
    {
        public string Couleur { get; set; }
        public string Marque { get; set; }
        public int Vitesse { get; set; }

        public int CompareTo(object obj)
        {
            Voiture voiture = (Voiture)obj;
            return Vitesse.CompareTo(voiture.Vitesse);
        }

		public override bool Equals(object obj)
		{
            Voiture v = obj as Voiture;
            if (v == null)
                return false;
            return Vitesse == v.Vitesse && Couleur == v.Couleur && Marque == v.Marque;
		}

		public override int GetHashCode()
		{
            return Couleur.GetHashCode() * Marque.GetHashCode() * Vitesse.GetHashCode();
		}
	}
}
