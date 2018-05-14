using System;
namespace CSProject
{
    public class Manager : Staff
    {
        // Fields
        private const float managerHourlyRate = 50.0f;

        // Properties
        public int Allowance { get; private set; }

        //Constructor
        public Manager(string name) : base(name, managerHourlyRate)
        {
            // No code here.
        }

		// Method
		public override void CalculatePay()
		{
            // Set BasicPay and TotalPay in base (parent) class
            base.CalculatePay();
            Allowance = 1000;

            if (HoursWorked > 160)
            {
                TotalPay = BasicPay + Allowance;
            }
		}

		public override string ToString()
		{
            return "\nNameOfStaff = "    + NameOfStaff +
                "\nmanagerHourlyRate = " + managerHourlyRate +
                "\nHoursWorked = "       + HoursWorked +
                "\nAllowance = "         + Allowance +
                "\nBasicPay = "          + BasicPay +
                "\n\nTotalPay = "        + TotalPay;
		}
	}
}
