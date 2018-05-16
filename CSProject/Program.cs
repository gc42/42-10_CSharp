using System;
using System.Collections.Generic;

namespace CSProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Staff> myStaff = new List<Staff>();
			FileReader  fr = new FileReader();
            int         month   = 0;
			int         year    = 0;

            // Input Year and test if it is valid
            while (year == 0)
            {
                Console.Write("\nPlease enter a year: ");

                try
                {
					//Code to convert the input to an integer
                    year = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("This is not a valid year. Try again.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("This a litle bit far in the future! Try again.");
                }
            }

            // Input MOUNTH and test if it is valid
            while (month == 0)
            {
                Console.Write("\nPlease enter a month: ");

                try
                {
                    //Code to convert the input to an integer
                    month = Convert.ToInt32(Console.ReadLine());

                    if (month < 1 || month > 12)
                    {
                        month = 0;
                        Console.WriteLine("Only 12 month in a year. Please enter a number between 1 and 12.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("This is not a valid month number. Try again.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("There are not so much month in a year! Try again.");
                }


            }

            myStaff = fr.ReadFile();

            for (int i = 0; i < myStaff.Count; i++)
            {
                try
                {
                    Console.Write("Enter hours worked for {0}:", myStaff[i].NameOfStaff);
                    myStaff[i].HoursWorked = Convert.ToInt32(Console.ReadLine());
                    myStaff[i].CalculatePay();
                    Console.WriteLine(myStaff[i].ToString());
                }
                catch (Exception e)
                {
                    i--;
                    Console.WriteLine(e.Message + "A number please!"); 
                }


            }

            PaySlip ps = new PaySlip(month, year);
            ps.GeneratePaySlip(myStaff);
            ps.GenerateSummary(myStaff);

            // To maintain the Console Open. Not needed here.
            //Console.Read();
        }


    }
}
