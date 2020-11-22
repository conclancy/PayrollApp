using System;
using System.Collections.Generic;

namespace PayrollCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Feilds for program 
            int month = 0;
            int year = 0;
            int action = 0;

            // Validate and set month feild
            while (month == 0)
            {
                Console.WriteLine("Please enter month number:");
                try
                {
                    int m = Convert.ToInt32(Console.ReadLine());
                    if (m > 0 && m < 13)
                    {
                        month = m;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}.  Please try again.");
                }
            }

            // Validate and set year feild
            while(year == 0)
            {
                Console.WriteLine("Please enter the year:");
                try
                {
                    year = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}.  Please try again.");
                }
            }

            // Import pay inormation from staff.txt file
            FileReader fr = new FileReader();
            List<Staff> myStaff = fr.ReadFile();
            PaySlip ps = new PaySlip(month,year);

            // Main program for user to interact with pay information. 
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please select payroll action:");
                Console.WriteLine("");
                Console.WriteLine("1. - Calculate pay");
                Console.WriteLine("2. - View all payslips");
                Console.WriteLine("3. - View single payslip");
                Console.WriteLine("4. - Exit");
                Console.WriteLine("");

                // Validate and set next action
                try
                {
                    action = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}.  Please type the action number.");
                    Console.ReadLine();
                }

                // Execute validated action
                switch (action)
                {
                    // Calculate employee's pay
                    case 1:
                        Console.Clear();
                        foreach (Staff s in myStaff)
                        {
                            s.CalculatePay();
                            Console.WriteLine($"{s.NameOfStaff} pay calculated.");
                        }
                        action = 0;
                        Console.WriteLine("Calculations completed.  Press any key to continue.");
                        Console.ReadLine();
                        break;

                    // Print all employee's pay information
                    case 2:
                        Console.Clear();
                        foreach (Staff s in myStaff)
                        {
                            ps.GeneratePaySlip(s);
                        }
                        action = 0;
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                        break;

                    // Print a specific employee's pay information
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Enter the employee's name:");
                        string staffName = Console.ReadLine();
                        foreach (Staff s in myStaff)
                        {
                            if (s.NameOfStaff.ToLower() == staffName.ToLower())
                            {
                                ps.GeneratePaySlip(s);
                            }
                        }
                        action = 0;
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                        break;

                    // Break the while loop and end the program
                    case 4:
                        return;

                    // Reset the action and return to the main menu
                    default:
                        action = 0;
                        break;

                }
            }
        }
    }
}
