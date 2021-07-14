using System;
using System.IO;

namespace EmployeeTracker
{
    public class Hourly : Employee
    {
        //Protected fields
        protected decimal _payPerHour;
        protected decimal _hoursPerWeek;

        //File Location
        private static string _directory = "../../../Output/employees.txt";

        public Hourly(string name, string address, decimal payPerHour, decimal hoursPerWeek) : base(name, address)
        {
            _payPerHour = payPerHour;
            _hoursPerWeek = hoursPerWeek;

        }


    }
}
