using System;
using System.IO;

namespace EmployeeTracker
{
    public class Salaried : Employee
    {
        //Fields
        private decimal _salary;
        private static string _directory = "../../../Output/employees.txt";


        public Salaried(string name, string address, decimal salary): base (name, address)
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


            //Add the  user information to a string
            string userData = $"{employeeName};{employeelocation};40;{salary} ";

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
