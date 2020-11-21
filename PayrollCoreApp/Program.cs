using System;

namespace PayrollCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Staff connor = new Staff("Connor",30f);
            connor.HoursWorked = 40;
            connor.CalculatePay();
            Console.WriteLine(connor.ToString());
        }
    }
}
