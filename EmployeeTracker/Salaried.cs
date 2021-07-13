using System;
namespace EmployeeTracker
{
    public class Salaried : Employee
    {
        //Fields
        private decimal _salary;

        public Salaried(string name, string address, decimal salary): base (name, address)
        {
        }

        public static Salaried AddEmployee()
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

            Console.Write("Employee Salary: ");
            decimal salary = Validation.DecimalValidation(Console.ReadLine());

            Console.Write("Hours Per Week: ");
            decimal weekHours = Validation.DecimalValidation(Console.ReadLine());


            //Confirm creation 
            Console.WriteLine("\r\nEmployee Created!");


            Salaried employee = new Salaried(employeeName, employeelocation, salary);

            return employee;
        }
    }
}
