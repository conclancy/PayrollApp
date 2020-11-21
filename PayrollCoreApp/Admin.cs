using System;
namespace PayrollCoreApp
{
    public class Admin: Staff
    {
        // Feilds
        private const float overtimeRate = 15.5f;
        private const float adminHourlyRate = 30f;

        // Properties
        public float Overtime { get; private set; }

        // Constructor extending base constructor
        public Admin(string name): base(name, adminHourlyRate)
        {
        }

        public override void CalculatePay()
        {
            base.CalculatePay();

            if (HoursWorked > 160)
            {
                Overtime = overtimeRate * (HoursWorked - 160);
                TotalPay = BasicPay + Overtime;
            }
        }

        // Method for overriding ToString() method
        public override string ToString()
        {
            return $"\nName: {NameOfStaff} \nHourly Rate: {hourlyRate:c} \nHours Worked: {HoursWorked} \nBase Pay: {BasicPay:c} \nOvertime: {Overtime:c} \nTotal Pay: {TotalPay:c}";
        }
    }
}
