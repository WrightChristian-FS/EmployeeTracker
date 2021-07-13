using System;
namespace EmployeeTracker
{
    public class Manager : Salaried 
    {
        //Fields
        private decimal _bonus; 

        public Manager(string name, string address, decimal salary, decimal bonus) : base (name, address, salary)
        {
        }

        public static Manager AddEmployee()
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

            Console.Write("Bonus Amount: ");
            decimal bonus = Validation.DecimalValidation(Console.ReadLine());

            //Confirm creation 
            Console.WriteLine("\r\nEmployee Created!");

            Manager employee = new Manager(employeeName, employeelocation, salary, bonus);

            return employee;
        }



        public override decimal CalculatePay(Employee employee)
        {
            //Create a variable to hold the salary 
            decimal salary = 0;


            salary = salary + _bonus;


            //Return the salary to the user 
            return salary;
        }
    }
}
