using System;
namespace EmployeeTracker
{
    public class FullTime : Hourly 
    {
        public FullTime(string name, string address, decimal payPerHour, decimal hoursPerWeek) : base(name, address, payPerHour,hoursPerWeek)
        {
            //Set hpw to 40
        }
    }
}
