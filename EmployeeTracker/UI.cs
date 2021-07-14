using System;
namespace EmployeeTracker
{
    public class UI
    {
        public UI()
        {
        }

        public static void HeaderUI()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen; 
        }

        public static void InputUI()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;

        }

        public static void StandardUI()
        {

            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
