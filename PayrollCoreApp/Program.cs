using System;
using System.Collections.Generic;

namespace PayrollCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Staff connor = new Staff("Connor",30f);
            connor.HoursWorked = 40;

            Manager lazyManager = new Manager("lazy");
            lazyManager.HoursWorked = 80;

            Manager hardWorkingManager = new Manager("Hard Working");
            hardWorkingManager.HoursWorked = 161;

            Admin lazyAdmin = new Admin("ALazy");
            lazyAdmin.HoursWorked = 80;

            Admin hardWorkingAdmin = new Admin("AHardWork");
            hardWorkingAdmin.HoursWorked = 161;

            List<Staff> employees = new List<Staff> { connor, lazyManager, hardWorkingManager, lazyAdmin, hardWorkingAdmin };

            foreach (Staff s in employees)
            {
                Console.WriteLine("");
                Console.WriteLine(DateTime.Now.ToString()); ;
                s.CalculatePay();
                Console.WriteLine(s.ToString());
            }
        }
    }
}
