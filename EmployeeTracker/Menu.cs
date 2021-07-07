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

        public static int Display()
        {
            //Print the Header
            //PRINT HEADER
            Console.Write($"********** {_title} **********\r\n");


            //Print the menu options
            foreach (string item in _menuItems)
            {
                Console.WriteLine($"[{_menuItems.IndexOf(item) + 1 }] {item,-110}");
            }

            int menuItemcount = _menuItems.Count;

            return menuItemcount;

        }
    }
}
