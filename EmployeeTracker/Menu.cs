using System;
using System.Collections.Generic; 
namespace EmployeeTracker
{
    public class Menu
    {
        //Fields
        private static string _title;
        private static List<string> _menuItems;

        public static void Init(string title, List<string> menuItems)
        {
            _title = title;
            _menuItems = menuItems;
        }

        public static void Display()
        {

            //Header
            Console.WriteLine("====================");
            Console.WriteLine($"{_title}");
            Console.WriteLine("====================");

            //Print the menu options 
            foreach (string item in _menuItems)
            {
                Console.WriteLine($"{_menuItems.IndexOf(item) + 1}: {item}");
            }
        }
    }
}
