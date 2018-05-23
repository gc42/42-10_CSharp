using System;
namespace OCRoom2_p02
{
    public class Chat : Animal
    {
        // Constructor
        public Chat(string prenomDuChat) : base(prenomDuChat)
        {
        }

        // Methods
        public override void Cri()
        {
            Console.WriteLine("Miaou, Miaou !");
        }


        public override string ToString()
        {
            return "Je suis un chat " + " et je m'appelle " + base.prenom;
        }
    }
}
