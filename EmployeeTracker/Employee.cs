using System;
namespace EmployeeTracker
{
    public class Employee
    {
        //Protected fields
        protected string _address;

        //Properties
        protected string Name { get; set; }
        protected string Address { get; set; }

        public Employee(string name, string address)
        {
            Name = name;
            Address = address; 
        }

        public virtual decimal CalculatePay(Employee employee)
        {
            //Create a variable to hold the salary 
            decimal salary = 0;


            //Return the salary to the user 
            return salary; 
        }

        public virtual Employee AddEmployee ()
        {
            Console.Clear();

            //Header
            UI.HeaderUI(); 
            Console.WriteLine("====================");
            Console.WriteLine($"   Add Employee");
            Console.WriteLine("====================\r\n");
            UI.StandardUI(); 

            Console.Write("Employee Name: ");
            string employeeName = Validation.StringValidation(Console.ReadLine());

            Console.Write("Employee Location(City, State): ");
            string employeelocation = Validation.StringValidation(Console.ReadLine());

            Console.Write("Employee Hourly Rate: ");
            decimal hourlyRate = Validation.DecimalValidation(Console.ReadLine());

            Console.Write("Hours Per Week: ");
            decimal weekHours = Validation.DecimalValidation(Console.ReadLine());


            Employee employee = new PartTime(employeeName, employeelocation, hourlyRate, weekHours);

            return employee;


        }

     

    }
}
