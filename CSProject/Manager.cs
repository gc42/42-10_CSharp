using System;
namespace CSProject
{
    public class Manager : Staff
    {
        // Fields
        private const float managerHourlyRate = 50.0f;
        private const int   managerOverTime   = 160;

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

            if (HoursWorked > managerOverTime)
            {
                TotalPay = BasicPay + Allowance;
            }
            else
                Allowance = 0;
		}

        TASK

		public override string ToString()
		{
            return 
                "\n---------------------------------------" +
                "\nNameOfStaff        = " + NameOfStaff +
				"\nHoursWorked        = " + HoursWorked +
                "\nmanagerHourlyRate  = " + managerHourlyRate +
				"\nBasicPay           = " + BasicPay +
                "\nAllowance          = " + Allowance +
                "\n" +
                "\nTotalPay           = " + TotalPay +
                "\n---------------------------------------";
		}
	}
}
