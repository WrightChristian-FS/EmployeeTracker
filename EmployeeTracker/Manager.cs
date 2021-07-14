using System;
using System.IO;

namespace EmployeeTracker
{
    public class Manager : Salaried 
    {
        //Fields
        private decimal _bonus;

        private static string _directory = "../../../Output/employees.txt";
        
        

        public Manager(string name, string address, decimal salary, decimal bonus) : base (name, address, salary)
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

            Console.Write("Employee Annual Salary: ");
            UI.InputUI(); 
            decimal salary = Validation.DecimalValidation(Console.ReadLine());
            UI.StandardUI();

            Console.Write("Bonus Amount: ");
            UI.InputUI(); 
            decimal bonus = Validation.DecimalValidation(Console.ReadLine());
            UI.StandardUI();

            //Calculate the employee salary 
            decimal employeeSalary = salary + bonus;

            //Add the  user information to a string
            string userData = $"{employeeName};{employeelocation};40;{employeeSalary} ";

            //Add the user to the employee list file
            using (StreamWriter sw = File.AppendText(_directory))
            {
                sw.WriteLine(userData);
            }


            //Confirm creation 
            Console.WriteLine("\r\nEmployee Created!");

            

            
        }


    }
}
