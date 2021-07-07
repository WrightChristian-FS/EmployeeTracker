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

    }
}
