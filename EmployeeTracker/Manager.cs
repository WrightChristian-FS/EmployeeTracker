using System;
namespace EmployeeTracker
{
    public class Manager : Salaried 
    {
        //Fields
        private decimal _bonus; 

        public Manager(string name, string address, decimal salary, decimal bonus) : base (name, address, salary)
        {
        }
    }
}
