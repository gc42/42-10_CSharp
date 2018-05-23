using System;
namespace OCRoom2_p05
{
    public class Oiseau : IVolant
    {
        public int NombrePropulseurs { get; set; }

        public void Voler()
        {
            Console.WriteLine("Je suis un oiseau \t et je vole grace a " + NombrePropulseurs + " ailes");
        }
    }
}
