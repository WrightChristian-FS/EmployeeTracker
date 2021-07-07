using System;
using System.Collections.Generic;

namespace EmployeeTracker
{
    public class Application
    {

        //Fields
        private static List<string> _menu;
        

        public Application()
        {

            //Inportant Variables
            bool continueApplication = true;
            List<Employee> employeeList = new List<Employee>();

            //Create the main menu


            while (continueApplication)
            {
                //Create the Main Menu List
                MainMenu();

                //Set the Menu & Display the menu to the user
                Menu.Init("Main Menu", _menu);
                Menu.Display();

                //Ask the user to make a selection & validate the answer
                Console.Write("\r\nPlease enter your selection: ");
                int userMenuSelection = Validation.MenuValidation(Console.ReadLine(), _menu.Count);

                switch (userMenuSelection)
                {
                    case 1:
                        AddEmployee(); 
                        break;

                    case 2:
                        RemoveEmployee(); 
                        break;

                    case 3:
                        DisplayPayroll(); 
                        break;

                    case 4:
                        Exit();
                        continueApplication = false; 
                        break;
                }


            }



        }

        public static void MainMenu()
        {

            List<string> menu = new List<string>(); 
            //Add the main menu items to the main menu list
            menu.Add("Add Employee");
            menu.Add("Remove Employee");
            menu.Add("Display Payroll");
            menu.Add("Exit");

            _menu = menu; 
        }

        public static void AddEmployeeMenu()
        {
            List<string> menu = new List<string>();

            menu.Add("Full Time");
            menu.Add("Part Time");
            menu.Add("Salaried");
            menu.Add("Manager");
            menu.Add("Back to Main Menu");

            _menu = menu; 
        }

        public static void AddEmployee()
        {
            //Clear the console
            Console.Clear(); 

            //Instantuate the add employee menu and display it to the user
            AddEmployeeMenu();
            Menu.Init("ADD AN EMPLOYEE" ,_menu);
            Menu.Display();

            Console.Write("\r\nPlease enter your selection: ");
            int userMenuSelection = Validation.MenuValidation(Console.ReadLine(), _menu.Count);

            switch (userMenuSelection)
            {
                case 1:
                    Hourly fullTineEmployee = Hourly.AddEmployee(); 
                    break;

                case 2:
                    Hourly partTimeEmployee = Hourly.AddEmployee();
                    break;

                case 3:
                    Salaried salaryEmployee = Salaried.AddEmployee();
                    break;

                case 4:
                    Manager manager = Manager.AddEmployee(); 
                    break;

                case 5:
                    Console.WriteLine("\r\nBack main menu");
                    break;
            }





            Continue(); 
        }


        public static void RemoveEmployee()
        {
            Console.WriteLine("====================");
            Console.WriteLine($"REMOVE EMPLOYEE");
            Console.WriteLine("====================\r\n");

            Continue();

        }

        public static void DisplayPayroll()
        {
            Console.WriteLine("====================");
            Console.WriteLine($"DISPLAY PAYROLL");
            Console.WriteLine("====================\r\n");

            Continue();

        }

        public static void Exit()
        {
            Console.WriteLine("EXIT METHOD");
            Continue();

        }

        public static void Continue()
        {
            //Ask user to acknowledge end of step, clear the console.
            Console.Write("\r\nPress any key to continue... ");
            Console.ReadLine();
            Console.Clear(); 
        }

    }
}
