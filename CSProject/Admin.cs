using System;
namespace CSProject
{
    public class Admin : Staff
    {
        // Fields
        private const float     overtimeRate    = 15.5f;
        private const float     adminHourlyRate = 30.0f;

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

            if (HoursWorked > 160)
            {
                Overtime = overtimeRate * (HoursWorked - 160);
                TotalPay = TotalPay + Overtime;
            }
        }

        public override string ToString()
        {
            return "\nNameOfStaff = " + NameOfStaff +
                "\nadminHourlyRate = " + adminHourlyRate +
                "\nHoursWorked = " + HoursWorked +
                "\nBasicPay = " + BasicPay +
                "\nOvertime = " + Overtime +
                "\n\nTotalPay = " + TotalPay;
        }
	}
}
