using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.IO;

namespace TextFileDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string path = "/Users/gcaron/projects/C#_Tuto/TextFileDemo/myFile.txt";

            // Reading from the file, METHOD USING 'try / catch'
            /*
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.EndOfStream != true)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                    sr.Close();
                }
            } catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            */



            //Writing to the file
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("\n");
                sw.WriteLine("ABC");
                sw.WriteLine("DEF");
                sw.Close();
            }

            //Reading from the file, METHOD USING 'File.Exist'
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.EndOfStream != true)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                    sr.Close();
                }
            }
            else
            {
                //Do something else
                Console.WriteLine("Peut pas trouver le fichier.");
            }


        }
    }
}
