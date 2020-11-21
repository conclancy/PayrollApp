using System;
namespace PayrollCoreApp
{
    public class Staff
    {
        // Create feilds
        protected float hourlyRate;
        private int hWorked;

        // Create properties
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

        // Constructor for Staff object
        public Staff(string name, float rate)
        {
            NameOfStaff = name;
            hourlyRate = rate;
        }

        // Method for calculating basic and total pay
        public virtual void CalculatePay()
        {
            Console.WriteLine("\nCalculating Pay...");
            BasicPay = hWorked * hourlyRate;
            TotalPay = BasicPay;
        }

        // Method for overriding ToString() method
        public override string ToString()
        {
            return $"\nName: {NameOfStaff} \nHourly Rate: {hourlyRate:c} \nHours Worked: {HoursWorked} \nBase Pay: {BasicPay:c} \nTotal Pay: {TotalPay:c}";
        }
    }
}
