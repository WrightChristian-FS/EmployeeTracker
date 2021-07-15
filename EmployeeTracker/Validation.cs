using System;
namespace EmployeeTracker
{
    public class Validation
    {

        public static string StringValidation(string userInput)
        {
            //Validate the user input to ensure that it was not left blank or empty
            while (string.IsNullOrWhiteSpace(userInput))
            {
                //State the problem
                Console.WriteLine("\r\nThis can not be left blank or empty ");

                //Repeat the question
                Console.Write("Please enter a valid answer: ");

                //Capture the answer
                userInput = Console.ReadLine(); 
            }

            return userInput; 
        }

        public static int MenuValidation(string userInput, int menuCount)
        {
            int convertedInput;

            while(!(int.TryParse(userInput, out convertedInput)) || convertedInput > menuCount)
            {
                //State the problem
                Console.WriteLine("\r\nSorry, that is not a valid menu selection");

                //Repeat the question
                Console.Write("Please enter a valid menu selection: ");

                //Capture the answer
                userInput = Console.ReadLine(); 
            }

            return convertedInput; 
        }

        public static decimal DecimalValidation(string userInput)
        {
            decimal convertedInput;


            while(!(decimal.TryParse(userInput, out convertedInput)))
            {
                //State the problem
                Console.WriteLine("\r\nSorry that is not a valid decimal!");

                //Repeat the question
                Console.Write("Please enter a valid decimal number: ");

                //capture the answer
                userInput = Validation.StringValidation(Console.ReadLine()); 
            }

            return convertedInput; 

        }


        public static int IntegerValidation(string userInput, int userCount)
        {
            int convertedInput;


            while(!(int.TryParse(userInput, out convertedInput)) || (convertedInput > userCount + 1))
            {
                //State the problem
                Console.WriteLine("Sorry, that is not a valid number");

                //Repeat the question
                Console.Write("Please enter a valid number: ");

                //Capture the answer
                UI.InputUI();
                userInput = Console.ReadLine();
                UI.StandardUI(); 
            }


            return convertedInput; 
        }


        public static bool YesNoValidation(string userInput, int userCount)
        {
            bool returnValue;
            


            while((userInput.ToLower() != "yes") && (userInput.ToLower() != "no") )
            {
                //State the probem
                Console.WriteLine("Sorry, that is not a valid Yes or No answer!");

                //Repeat the question
                Console.Write("Would you like to remove the employee (yes/No):");

                //Capture the answer
                UI.InputUI();
                userInput = Console.ReadLine();
                UI.StandardUI(); 
            }

            if(userInput.ToLower() == "yes")
            {
                returnValue = true; 
            } else
            {
                returnValue = false; 
            }


            return returnValue; 
        }

    }
}
