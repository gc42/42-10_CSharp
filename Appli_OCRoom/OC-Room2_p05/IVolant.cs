using System;
namespace OCRoom2_p05
{
    public interface IVolant
    {
        int NombrePropulseurs { get; set; }
        void Voler();
    }
}
