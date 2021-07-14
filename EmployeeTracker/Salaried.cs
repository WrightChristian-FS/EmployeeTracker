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

            //Confirm creation 
            Console.WriteLine("\r\nEmployee Created!");


            Salaried employee = new Salaried(employeeName, employeelocation, salary);

            return employee;
        }
    }
}
