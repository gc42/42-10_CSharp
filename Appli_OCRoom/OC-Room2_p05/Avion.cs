using System;
namespace OCRoom2_p05
{
    public class Avion : IVolant
    {
        public int      NombrePropulseurs { get; set ; }
        public string   NomDuCommandant { get; set; }

        public void Voler()
        {
            Console.WriteLine("Je suis un avion \t et je vole grace a " + NombrePropulseurs + " moteurs"); ;
        }
    }
}
