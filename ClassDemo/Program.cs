using System;
using System.Collections.Generic;
namespace ClassDemo
{

    class Staff
    {
        // 'private' is an acces modifier (private, public, protected, internal)
        // 'Fields'  are variables declared inside a Class
        // 'const'   cannot be modified after creation+declaration
        private string      nameOfStaff;        
        private const int   hourlyRate = 30;
        private int         hWorked;



        public int HoursWorked  // 'property' with PascalCasing name
        {
            // Two special methods named 'assessors'
            get                 // 'getter' method
            {
                return hWorked; // 'backing' field of the 'property'
            }

            set                 // 'setter' method
            {
                if (value > 0)
                    hWorked = value;
                else
                    hWorked = 0;
            }
        }


        public int HoursWorked1
        {
            get { return hWorked;  }
            set { hWorked = value; }
        }

        public int HoursWorked2 { get; set; }           // Is equivalent to version 1 just above
        public int HoursWorked3 { get; private set; }   // Is equivalent, with 'set' method as private (read only)

        // 'method' is a code block that perfoms a certain task
        // accessibility=public, return type=void, name=name, (parameters)
        public void PrintMessage()
        {   // Implementing the method
            
            Console.WriteLine("Calculating Pay...");
        }



        // Method who calculates the Pay and return the result
        public int CalculatePay()
        {
            PrintMessage();                 // Calling the PrintMessage() method

            int staffPay;
            staffPay = hWorked * hourlyRate;

            if (hWorked > 0)
                return staffPay;
            else
                return 0;
        }



        // Peuvent avoir le meme 'nom', si les 'signatures' sont differentes
        public int CalculatePay(int bonus, int allowance)
        {
            PrintMessage();

            if (hWorked > 0)
                return hWorked * hourlyRate + bonus + allowance;
            else
                return 0;
        }



		//
		public override string ToString()
		{
            return "Name of Staff = " + nameOfStaff + ", hourlyRate = " + hourlyRate + ", hWorked = " + hWorked;
		}



        //Constructor
        public Staff(string name)
        {
            nameOfStaff = name;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("-----------------------------");
        }

        public Staff(string firstName, string lastName)
        {
            nameOfStaff = firstName + " " + lastName;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("-----------------------------");

        }
	}

    class MyClass
    {
        // NON STATIC members
        public string message = "Hello My World";
        public string Name { get; set; }
        public void DisplayName()
        {
            Console.WriteLine("Name = {0}", Name);
        }

        // STATIC members
        public static string greetings = "Good morning";
        public static int Age { get; set; }
        public static void DisplayAge()
        {
            Console.WriteLine("Age = {0}", Age);
        }
    }



    class Program
    {
        public static void Main(string[] args)
        {
            int pay;

            Staff staff1 = new Staff("Peter");
            staff1.HoursWorked = 160;
            pay = staff1.CalculatePay(1000, 400);

            Console.WriteLine("Pay = {0}", pay);

            Staff staff2 = new Staff("Jane", "Lee");
            staff2.HoursWorked = 160;
            pay = staff2.CalculatePay();

            Console.WriteLine("Pay = {0}", pay);

            Staff staff3 = new Staff("Cagole");
            staff3.HoursWorked = -10;
            pay = staff3.CalculatePay();

            Console.WriteLine("Pay = {0}", pay);


            // ----------------------
            MyClass classA = new MyClass();
            Console.WriteLine(classA.message);
            classA.Name = "Jamie";
            classA.DisplayName();

            Console.WriteLine(MyClass.greetings);
            MyClass.Age = 39;
            MyClass.DisplayAge();

            //----------------------
            int[] myArray = { 1, 2, 3, 4, 5 };
            PrintFirstElementInArray(myArray);

            List<int> myList = new List<int> { 10, 2, 3 };
            PrintFirstElementInList(myList);

            //----------------------ReturnUserInput as array/List
            int[] myReturnArray = ReturnUserInputAsArray();
            foreach (int i in myReturnArray)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("\n");

            List<int> myReturnList = ReturnUserInputAsList();
            foreach (int i in myReturnList)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("\n");

            //---------------------Parameters: nombre inconnu
            PrintNames("peter");
            PrintNames("Totor", "Motor");
            PrintNames("Patator", "Rotator", "Motricitor");

        }

        public static void PrintFirstElementInArray(int[] a)
        {
            Console.WriteLine("\n------------------\n");
            Console.WriteLine("The first element in array is {0}.\n", a[0]);
        }

        public static void PrintFirstElementInList(List<int> a)
        {
            Console.WriteLine("\n------------------\n");
            Console.WriteLine("The first element in list is {0}.\n", a[0]);
        }

        public static int[] ReturnUserInputAsArray()
        {
            int[] a = new int[3];

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter an integer: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Integer added to array.\n");
            }
            return a;
        }

        public static List<int> ReturnUserInputAsList()
        {
            List<int> a = new List<int>();
            int input;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter an Integer: ");
                input = Convert.ToInt32(Console.ReadLine());
                a.Add(input);
                Console.WriteLine("Integer entered to list.\n");
            }
            return a;
        }

        public static void PrintNames(params string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
