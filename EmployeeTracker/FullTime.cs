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

        public static Hourly AddEmployee()
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
            Console.Write("\r\nEmployee Location(City, State): ");
            UI.InputUI();
            string employeelocation = Validation.StringValidation(Console.ReadLine());

            UI.StandardUI();
            Console.Write("\r\nEmployee Hourly Rate: ");
            UI.InputUI();
            decimal hourlyRate = Validation.DecimalValidation(Console.ReadLine());
            UI.StandardUI();


            //Set the hours per week 
            decimal weekHours = 40;


            //Confirm creation 
            Console.WriteLine("\r\nEmployee Created!");


            Hourly employee = new Hourly(employeeName, employeelocation, hourlyRate, weekHours);

            return employee;
        }

        public override decimal CalculatePay(Employee employee)
        {
            //Create a variable to hold the salary 
            decimal salary = 0;


            salary = ((_payPerHour * _hoursPerWeek) * 52);


            //Return the salary to the user 
            return salary;
        }

    }
}
