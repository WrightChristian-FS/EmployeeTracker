using System;
namespace EmployeeTracker
{
    public class Employee
    {
        //Protected fields
        protected string _address;

        //Properties
        public string Name { get; set; }
        public string Address { get; set; }

        public Employee(string name, string address)
        {
            Name = name;
            Address = address; 
        }

        public virtual void CalculatePay()
        {

        }

    }
}
