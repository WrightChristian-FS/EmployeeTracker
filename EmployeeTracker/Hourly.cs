using System;
namespace EmployeeTracker
{
    public class Hourly : Employee
    {
        //Protected fields
        protected decimal _payPerHour;
        protected decimal _hoursPerWeek; 

        public Hourly(string name, string address, decimal payPerHour, decimal hoursPerWeek): base (name, address)
        {
            _payPerHour = payPerHour;
            _hoursPerWeek = hoursPerWeek;


        }
    }
}
