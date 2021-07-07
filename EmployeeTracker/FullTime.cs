using System;
namespace EmployeeTracker
{
    public class FullTime : Hourly 
    {
        public FullTime(string name, string address, decimal payPerHour, decimal hoursPerWeek) : base(name, address, payPerHour,hoursPerWeek)
        {
            decimal hours = 40;

            hoursPerWeek = hours; 
        }


       //public static FullTime AddEmployee()
       // {

       //     Console.Clear();

       //     //Header
       //     Console.WriteLine("====================");
       //     Console.WriteLine($"Add Employee");
       //     Console.WriteLine("====================\r\n");


       //     Console.Write("Employee Name: ");
       //     string employeeName = Validation.StringValidation(Console.ReadLine());

       //     Console.Write("Employee Location(City, State): ");
       //     string employeelocation = Validation.StringValidation(Console.ReadLine());

       //     Console.Write("Employee Hourly Rate: ");
       //     decimal hourlyRate = Validation.DecimalValidation(Console.ReadLine());

       //     Console.Write("Hours Per Week: ");
       //     decimal weekHours = Validation.DecimalValidation(Console.ReadLine());


       //     FullTime employee = new FullTime(employeeName, employeelocation, hourlyRate, weekHours);

       //     return employee;

       // }

    }
}
