using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HelloWorld
{
    // A simple program to display Hello World

    class Program
    {

        static int[] userAge = { 21, 22, 23, 24, 25 };
        static int[] source = { 12, 1, 5, -2, 16, 14 };
        static int[] dest = { 1, 2, 3, 4 };
        static int testAge = 20;

        static string names = "Peter, John, Andy, , David";

        List<int> userAgeList = new List<int> { 11, 21, 31, 41 };

        static void Main(string[] args)
        {
            WriteLine("Hello World");

            Console.WriteLine(userAge[2]);
            userAge[2] = userAge[2] + 20;
            Console.WriteLine(userAge[2]);

            Console.WriteLine("Nombre de caracteres : " + userAge.Length);
            Console.WriteLine(testAge);



            // Copier les 3 premiers elements d'un Array vers un autre
            Array.Copy(source, dest, 3);
            Console.WriteLine("The Dest [0] element : " + dest[0]);

            int i = 0;
            while (i < source.Length)
            {
                Console.WriteLine("The source [" + i + "] element : " + source[i]);
                i++;
            }

            // Trier les champs d'un Array
            Array.Sort(source);
            i = 0;
            while (i < source.Length)
            {
                Console.WriteLine("The source [" + i + "] element : " + source[i]);
                i++;
            }
            Console.WriteLine("\n");



            // Splitter les champs d'un string en utilisant un tableau de separateurs (separator)
            string[] separator = { ", ", "; " };
            string[] substrings = names.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            i = 0;
            while (i < substrings.Length)
            {
                Console.WriteLine("The splitted [" + i + "] element : " + substrings[i]);
                i++;
            }
            Console.WriteLine("\n");


            List<int> userAgeList = new List<int> { 11, 21, 41, 51 };
            Console.Write("Elements in the list : ");
            i = 0;
            while (i < userAgeList.Count)
            {
                Console.Write("[" + i + "]" + userAgeList[i] + "; ");
                i++;
            }
            Console.WriteLine("\n");
            userAgeList.Add(61);
            userAgeList.Add(71);
            userAgeList.Insert(2, 31);
            i = 0;
            Write("Slitted elements : ");
            while (i < userAgeList.Count)
            {
                Console.Write("[" + i + "]" + userAgeList[i] + "; ");
                i++;
            }

            Console.WriteLine("\n");
            userAgeList.Remove(11);
            Write("Slitted elements : ");
            i = 0;
            while (i < userAgeList.Count)
            {
                Console.Write("[" + i + "]" + userAgeList[i] + "; ");
                i++;
            }
            Console.WriteLine("\n");

            // Verifie que la List contient (21)
            Console.WriteLine(userAgeList.Contains(21));


            Console.WriteLine("The number is {0:F3}.", 123.456789);

            Console.Write("Taper un texte, puis valider : ");
            string userInputText = Console.ReadLine();
            Console.WriteLine(userInputText);

            Console.Write("Taper un chiffre, puis valider : ");
            string userInput = Console.ReadLine();
            int result = 0;

            try
            {
                result = Convert.ToInt32(userInput);
                Console.WriteLine("Converted the {0} value '{1}' to the {2} value {3}.",
                                  userInput.GetType().Name, userInput, result.GetType().Name, result);
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} is outside the range of the Int32 type.", userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("The {0} value '{1}' is not in a recognizable format.",
                                  userInput.GetType().Name, userInput);
            }

            Console.WriteLine("{0:F2}", result);
        }
    }
}