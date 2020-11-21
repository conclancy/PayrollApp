using System;
namespace PayrollCoreApp
{
    // Manager is a child class of Staff class
    public class Manager: Staff
    {
        // Create feilds
        private const float managerHourlyRate = 50f;

        // Create properties
        public int Allowances { get; private set; }

        // Constructor extending base constructor
        public Manager(string name): base(name, managerHourlyRate)
        {
        }

        public override void CalculatePay()
        {
            base.CalculatePay();

            if (HoursWorked > 160)
            {
                Allowances = 1000;
                TotalPay = BasicPay + Allowances;
            }
        }

        // Method for overriding ToString() method
        public override string ToString()
        {
            return $"\nName: {NameOfStaff} \nHourly Rate: {hourlyRate:c} \nHours Worked: {HoursWorked} \nBase Pay: {BasicPay:c} \nAllowances: {Allowances:c} \nTotal Pay: {TotalPay:c}";
        }
    }
}
