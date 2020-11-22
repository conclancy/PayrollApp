using System;
namespace PayrollCoreApp
{
    public class PaySlip
    {
        enum MonthOfYear
        {
            JAN = 1,
            FEB = 2,
            MAR = 3,
            APR = 4,
            MAY = 5,
            JUN = 6,
            JUL = 7,
            AUG = 8,
            SEP = 9,
            OCT = 10,
            NOV = 11,
            DEC = 12
        }

        // Feilds
        private int month;
        private int year;

        // Properties
        public int Month
        {
            get
            {
                return month;
            }
            private set
            {
                if(value > 0 && value < 13)
                {
                    month = value;
                }
                else
                {
                    Console.WriteLine("Pleas enter a valid month number");
                }
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            private set
            {
                if(value > 2000)
                {
                    year = value;
                }
                else
                {
                    Console.WriteLine("Please enter a valid year");
                }
            }
        }

        public PaySlip(int month, int year)
        {
            Month = month;
            Year = year;
        }
    }
}
