using System;
using System.IO;

namespace EmployeeTracker
{
    public class PartTime : Hourly
    {

        private static string _directory = "../../../Output/employees.txt";

        public PartTime(string name, string address, decimal payPerHour, decimal hoursPerWeek) : base(name, address, payPerHour, hoursPerWeek)
        {
        }



        public static void AddEmployee()
        {

            Console.Clear();

            //Header
            UI.HeaderUI();
            Console.WriteLine("====================");
            Console.WriteLine($"   Add Employee");
            Console.WriteLine("====================\r\n");
            UI.StandardUI();


            Console.Write("Employee Name: ");
            UI.InputUI();
            string employeeName = Validation.StringValidation(Console.ReadLine());
            UI.StandardUI();

            Console.Write("Employee Location(City, State): ");
            UI.InputUI();
            string employeelocation = Validation.StringValidation(Console.ReadLine());
            UI.StandardUI();


            Console.Write("Employee Hourly Rate: ");
            UI.InputUI();
            decimal hourlyRate = Validation.DecimalValidation(Console.ReadLine());
            UI.StandardUI();


            Console.Write("Hours Per Week: ");
            UI.InputUI();
            decimal weekHours = Validation.DecimalValidation(Console.ReadLine());
            UI.StandardUI();


            //Calculate the employee salary
            decimal employeeSalary = CalculatePay(hourlyRate, weekHours);

            //Add user information to a string
            string userData = $"{employeeName};{employeelocation};{weekHours};{employeeSalary} ";

            //Add the user to the employee list file
            using (StreamWriter sw = File.AppendText(_directory))
            {
                sw.WriteLine(userData);
            }


            //Confirm creation 
            Console.WriteLine("\r\nEmployee Created!");

        }

        public static decimal CalculatePay(decimal rate, decimal hours)
        {
            //Create a variable to hold the salary 
            decimal salary = 0;


            salary = ((rate * hours) * 52);


            //Return the salary to the user 
            return salary;
        }
    }
}

