using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSProject
{
    public class PaySlip
    {
        //Fields
        private int month;
        private int year;

        //Enum
        enum MonthsOfYear
        {
            JAN = 1, FEV = 2, MAR = 3, AVR = 4, MAI = 5, JUN = 6, JUI = 7, AOU = 8, SEP = 9, OCT = 10, NOV = 11, DEC = 12
        }

        // Constructor
        public PaySlip(int payMonth, int payYear)
        {
            month = payMonth;
            year = payYear;
        }

        // Methods
        public void GeneratePaySlip(List<Staff> myStaff)
        {
            string generalPath = "/Users/gcaron/projects/C#_Tuto/CSProject/";
            string path;

            // Writing in the file, create if necessary, replace content

            foreach (Staff f in myStaff)
            {

                path = generalPath + f.NameOfStaff + ".txt";
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("PAYSLIP FOR {0} {1}", (MonthsOfYear)month, year);
                    sw.WriteLine("===================");
                    sw.WriteLine("Name of Staff: {0}", f.NameOfStaff);
                    sw.WriteLine("Hours Worked: {0}", f.HoursWorked);
                    sw.WriteLine("");
                    sw.WriteLine("Basic Pay: {0:C}", f.BasicPay);
                    if (f.GetType() == typeof(Manager))
                        sw.WriteLine("Allowance: {0:C}", ((Manager)f).Allowance);
                    else if (f.GetType() == typeof(Admin))
                        sw.WriteLine("Overtime: {0:C} hours", ((Admin)f).Overtime);
                    sw.WriteLine("");
                    sw.WriteLine("===================");
                    sw.WriteLine("Total Pay: {0:C}", f.TotalPay);
                    sw.WriteLine("===================");

                    sw.Close();
                }

            }

        }

        public void GenerateSummary(List<Staff> myStaff)
        {
            var result =
                from f in myStaff
                where f.HoursWorked < 10
                orderby f.NameOfStaff ascending
                select new { f.NameOfStaff, f.HoursWorked };

            string path = "/Users/gcaron/projects/C#_Tuto/CSProject/summary.txt";

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Staff with less than 10 working hours:\n");

                foreach (var f in result)
                {
                    sw.WriteLine("Name of Staff: {0}, Hours Worked: {1}", f.NameOfStaff, f.HoursWorked);
                }
                sw.Close();
            } 
        }

		public override string ToString()
		{
            return "month = " + month + ", year = " + year;
		}
	}
}
