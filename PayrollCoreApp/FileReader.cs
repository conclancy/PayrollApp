using System;
using System.Collections.Generic;
using System.IO;

namespace PayrollCoreApp
{
    public class FileReader
    {
        public List<Staff> ReadFile()
        {
            List<Staff> myStaff = new List<Staff>();
            string[] employee = new string[3];
            string path = "../../../staff.txt";
            string[] separator = { ", ", "; " };

            if (File.Exists(path))
            {
                using(StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        employee = sr.ReadLine().Split(", ");
                        switch (employee[1])
                        {
                            case "Manager":
                                Manager m = new Manager(employee[0])
                                {
                                    HoursWorked = Convert.ToInt32(employee[2])
                                };
                                myStaff.Add(m);
                                break;

                            case "Admin":
                                Admin a = new Admin(employee[0])
                                {
                                    HoursWorked = Convert.ToInt32(employee[2])
                                };
                                myStaff.Add(a);
                                break;

                            default:
                                Console.WriteLine($"{employee[0]} not added");
                                break;
                        }
                    }
                    sr.Close();
                }
                return myStaff;
            }
            else
            {
                Console.WriteLine("File not Found");
                return myStaff;
            }
        }
    }
}
