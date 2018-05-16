using System;
namespace CSProject
{
    public class Admin : Staff
    {
        // Fields
        private const float     overtimeRate    = 15.5f;
        private const float     adminHourlyRate = 30.0f;
        private const int       adminOverTime   = 160;


        // Properties
        public float Overtime { get; private set; }

        // Constructor
        public Admin(string name)   :   base(name, adminHourlyRate)
        {
            // No code here.
        }

        // Methods
        public override void CalculatePay()
        {
            // Set BasicPay and TotalPay in base (parent) class
            base.CalculatePay();

            if (HoursWorked > adminOverTime)
            {
                Overtime = overtimeRate * (HoursWorked - adminOverTime);
                TotalPay = TotalPay + Overtime;
            }
        }

        public override string ToString()
        {
            return
                "\n---------------------------------------" +
                "\nNameOfStaff        = " + NameOfStaff +
				"\nHoursWorked        = " + HoursWorked +
                "\nadminHourlyRate    = " + adminHourlyRate +
                "\nBasicPay           = " + BasicPay +
                "\nOvertime           = " + Overtime +
                "\n" +
                "\nTotalPay           = " + TotalPay +
                "\n---------------------------------------";
        }
	}
}
