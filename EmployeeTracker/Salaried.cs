using System;
namespace EmployeeTracker
{
    public class Salaried : Employee
    {
        //Fields
        private decimal _salary;

        public Salaried(string name, string address, decimal salary): base (name, address)
        {
        }
    }
}
