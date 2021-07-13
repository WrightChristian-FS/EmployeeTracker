using System;
namespace EmployeeTracker
{
    public class FullTime : Hourly 
    {
        public FullTime(string name, string address, decimal payPerHour, decimal hoursPerWeek) : base(name, address, payPerHour,hoursPerWeek)
        {
            decimal hours = 40;

            hoursPerWeek = hours; 
        }

        public override decimal CalculatePay(Employee employee)
        {
            //Create a variable to hold the salary 
            decimal salary = 0;


            salary = ((_payPerHour * _hoursPerWeek) * 52);


            //Return the salary to the user 
            return salary;
        }

    }
}
