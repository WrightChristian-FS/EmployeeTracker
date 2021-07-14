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

            Console.Write("Employee Annual Salary: ");
            UI.InputUI(); 
            decimal salary = Validation.DecimalValidation(Console.ReadLine());
            UI.StandardUI();

            Console.Write("Bonus Amount: ");
            UI.InputUI(); 
            decimal bonus = Validation.DecimalValidation(Console.ReadLine());
            UI.StandardUI();

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
