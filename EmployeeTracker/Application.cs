using System;
using System.Collections.Generic;

namespace EmployeeTracker
{
    public class Application
    {

        //Fields
        private static List<string> _mainMenu;
        

        public Application()
        {

            //Inportant Variables
            bool continueApplication = true;
            List<Employee> employeeList = new List<Employee>(); 

            //Create the main menu
            MainMenu();

            while (continueApplication)
            {
                
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

            _mainMenu = menu; 
        }

        public static void AddEmployee()
        {

        }


        public static void RemoveEmployee()
        {

        }

        public static void DisplayPayroll()
        {

        }

        public static void Exit()
        {

        }

        public static void Continue()
        {

        }

    }
}
