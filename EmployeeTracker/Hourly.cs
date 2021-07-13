using System;
namespace EmployeeTracker
{
    public class Hourly : Employee
    {
        //Protected fields
        protected decimal _payPerHour;
        protected decimal _hoursPerWeek; 

        public Hourly(string name, string address, decimal payPerHour, decimal hoursPerWeek): base (name, address)
        {
            _payPerHour = payPerHour;
            _hoursPerWeek = hoursPerWeek;

        }

        public static Hourly AddEmployee()
        {

            Console.Clear();

            //Header
            Console.WriteLine("====================");
            Console.WriteLine($"Add Employee");
            Console.WriteLine("====================\r\n");


            Console.Write("Employee Name: ");
            string employeeName = Validation.StringValidation(Console.ReadLine());

            Console.Write("Employee Location(City, State): ");
            string employeelocation = Validation.StringValidation(Console.ReadLine());

            Console.Write("Employee Hourly Rate: ");
            decimal hourlyRate = Validation.DecimalValidation(Console.ReadLine());

            Console.Write("Hours Per Week: ");
            decimal weekHours = Validation.DecimalValidation(Console.ReadLine());


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
