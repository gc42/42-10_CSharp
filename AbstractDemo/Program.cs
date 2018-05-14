using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            //MyAbstractClass abClass = new MyAbstractClass();
            ClassA a = new ClassA();
            a.PrintMessage();
            a.PrintMessageAbstract();
            //Console.Read();
        }
    }

    abstract class MyAbstractClass
    {
        private string message = "Hello C#. (de la classe parente)";
        public void PrintMessage()
        {
            Console.Write("Avec PrintMessage: ");
            Console.WriteLine(message);
        }

        public abstract void PrintMessageAbstract();
    }

    class ClassA : MyAbstractClass
    {
		public override void PrintMessageAbstract()
		{
            Console.Write("Avec override dans ClassA PrintMessageAbstract: ");
            Console.WriteLine("C# is fun!");
		}
	}
}
