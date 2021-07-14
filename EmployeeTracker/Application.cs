using System;
using System.Collections.Generic;
using System.IO;

namespace EmployeeTracker
{
    public class Application
    {

        //Fields
        private static List<string> _menu;
        private static string _directory = "../../../Output/employees.txt";
        private static List<string> employeeList; 




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
                    FullTime.AddEmployee();                    
                    Continue();
                    break;

                case 2:
                    PartTime.AddEmployee();
                    Continue();
                    break;

                case 3:
                    Salaried.AddEmployee();
                    Continue();
                    break;

                case 4:
                    Manager.AddEmployee();
                    Continue();
                    break;

                case 5:
                    //Return to the menu
                    Console.Clear(); 
                    break;
            }

        }


        public static void RemoveEmployee()
        {
            //Clear the console
            Console.Clear(); 

            UI.HeaderUI(); 
            Console.WriteLine("====================");
            Console.WriteLine($"REMOVE EMPLOYEE");
            Console.WriteLine("====================\r\n");
            UI.StandardUI();


            //Print the list headerts
            UI.InputUI();
            Console.WriteLine(String.Format("{0, -20} {1, -20} {2, -20} {3, -20}", "Employee Name", "Address", "Hours Per Week", "Salary"));
            UI.StandardUI();

            int lineCount = 0;

            //Print the user List 
            using (StreamReader sr = new StreamReader(_directory))
            {
                

                string line;

                while ((line = sr.ReadLine()) != null)
                {
                  
                    //Split the data 
                    string[] data = line.Split(';');                

                    //Print the employee 
                    Console.WriteLine($"{data[0],-20} {data[1],-20} {data[2],-20} ${data[3],-20}");


                    //Add employees to list
                    employeeList.Add(line); 
                }

            }



            //Ask the user which user they want to remove
            Console.Write("\r\nWhich employee do you want to remove: ");
            UI.InputUI();

            string employeeToRemove = Validation.StringValidation(Console.ReadLine());



            foreach(string line in employeeList)
            {
                string[] splitLine = line.Split(';');

                if (splitLine[0].Contains(employeeToRemove))
                { 




                }


            }





            Continue();

        }

        public static void DisplayPayroll()
        {

            //Clear the console,
            Console.Clear();

            //Print the header
            UI.HeaderUI(); 
            Console.WriteLine("====================");
            Console.WriteLine($"  DISPLAY PAYROLL");
            Console.WriteLine("====================\r\n");
            UI.StandardUI();

            //Print the list headerts
            UI.InputUI(); 
            Console.WriteLine(String.Format("{0, -20} {1, -20} {2, -20} {3, -20}", "Employee Name", "Address", "Hours Per Week", "Salary"));
            UI.StandardUI(); 

            using (StreamReader sr = new StreamReader(_directory))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {


                    string[] data = line.Split(';');

                    Console.WriteLine($"{data[0],-20} {data[1],-20} {data[2],-20} ${data[3],-20}");

                }
            }
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

