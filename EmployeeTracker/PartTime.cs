using System;
namespace EmployeeTracker
{
    public class PartTime : Hourly
    {
        public PartTime(string name, string address, decimal payPerHour, decimal hoursPerWeek) : base(name, address, payPerHour, hoursPerWeek)
        {
        }
    }
}
