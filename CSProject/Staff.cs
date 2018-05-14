using System;
namespace CSProject
{
    public class Staff
    {
        // Fields
        private float   hourlyRate;
        private int     hWorked;

        // Properties
        public float TotalPay { get; protected set; }
        public float BasicPay { get; private set; }
        public string NameOfStaff { get; private set; }

        public int HoursWorked
        {
            get
            {
                return hWorked;   
            }
            set
            {
                if (value > 0)
                    hWorked = value;
                else
                    hWorked = 0;
            }
        }

        // Constructor
        public Staff(string name, float rate)
        {
            NameOfStaff = name;
            hourlyRate = rate;
        }

        // Methods
        public virtual void CalculatePay()
        {
            //1 Print text on screen
            Console.WriteLine("Calculateing Pay...");

            //2 Assing BasicPay
            BasicPay = hWorked * hourlyRate;

            //3 Assing TotalPay
            TotalPay = BasicPay;
        }

        public override string ToString()
        {
            return "hourlyRate: " + hourlyRate +
                  "hWorked: " + hWorked +
                  "BasicPay: " + BasicPay +
                  "TotalPay: " + TotalPay +
                  "Name of Staff: " + NameOfStaff;
        }
    }
}
