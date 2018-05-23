using System;

namespace dev_exempleV01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // tableaux de données nécessaires au calcul de l'impôt;
            decimal[] limites = { 4962M, 8382M, 14753M, 23888M, 38868M, 47932M, 0M };
            decimal[] coeffR =  { 0M, 0.068M, 0.191M, 0.283M, 0.374M, 0.426M, 0.481M };
            decimal[] coeffN =  { 0M, 291.09M, 1322.92M, 2668.39M, 4846.98M, 6883.66M, 9505.54M };


            // on recuperes le statut marital
            bool OK = false;
            string reponse = null;
            while (!OK)
            {
                Console.Write("Etes-vous marie(e) (O/N) ? ");
                reponse = Console.ReadLine().Trim().ToLower();
                if (reponse != "o" && reponse != "n")
                    Console.WriteLine("Reponse incorrecte. Recommencez");
                else OK = true;
            }
            bool marie = reponse == "o";


            // Nombre d'enfants
            OK = false;
            int nbrEnfants = 0;
            while (!OK)
            {
                Console.Write("Nombre d'enfants : ");
                try
                {
                    nbrEnfants = int.Parse(Console.ReadLine());
                    OK = nbrEnfants >= 0;
                }
                catch {}
                if (!OK)
                    Console.WriteLine("Reponse incorrecte. Recommencez");
            }


            // Salaire
            OK = false;
            int salaire = 0;
            while (!OK)
            {
                Console.Write("Salaire annuel : ");
                try
                {
                    salaire = int.Parse(Console.ReadLine());
                    OK = salaire >= 0;
                }
                catch {}
                if (!OK)
                    Console.WriteLine("Reponse incorrecte. Recommencez");
            }


            // Calcul du nombre de parts
            decimal nbParts;
            if (marie) nbParts = (decimal)nbrEnfants / 2 + 2;
            else nbParts = (decimal)nbrEnfants / 2 + 1;
            if (nbrEnfants >= 3) nbParts += 0.5M;
            Console.WriteLine("Nombre de parts : {0}", nbParts);


            // Revenu imposable
            decimal revenu = 0.72M * salaire;
            Console.WriteLine("Revenu imposable : {0}", revenu);


            // Quotient familial
            decimal QF = revenu / nbParts;
            Console.WriteLine("Quotient familial : {0}", QF);


            // Recherche de la tranche d'impots correspondant a QF
            int i;
            int nbTranches = limites.Length;
            limites[nbTranches - 1] = QF;
            i = 0;
            while (QF > limites[i]) i++;


            // L'impot
            int impots = (int)(coeffR[i] * revenu - coeffN[i] * nbParts);


            // Affichage du resultat
            Console.WriteLine("Impot a payer : {0} euros", impots);
        }
    }
}
