using System;
using System.Collections.Generic;

namespace PayrollCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FileReader fr = new FileReader();
            List<Staff> myStaff = fr.ReadFile();
            foreach(Staff s in myStaff)
            {
                s.CalculatePay();
                Console.WriteLine(s.ToString());
            }
        }
    }
}
