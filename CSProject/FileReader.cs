using System;
using System.Collections.Generic;
using System.IO;

namespace CSProject
{
    public class FileReader
    {
        // Methods
        public List<Staff> ReadFile()
        {
            // Local Variables
            List<Staff> myStaff = new List<Staff>();
            string[] result = new string[2];
            string path = "/Users/gcaron/projects/C#_Tuto/CSProject/staff.txt";
            string[] separator = { ", " };


            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.EndOfStream != true)
                    {
                        result = sr.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);

                        if (result[1] == "Manager")
                        {
                            myStaff.Add(new Manager(result[0]));
                        }
                        else if (result[1] == "Admin")
                        {
                            myStaff.Add(new Admin(result[0]));
                        }

                    }
                    sr.Close();
                }

            }
            else
            {
                Console.WriteLine("Fucking File not found.");    
            }
            return myStaff;
        }


    }
}
