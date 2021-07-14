using System;
namespace EmployeeTracker
{
    public class Employee
    {
        //Protected fields
        protected string _address;

        //Properties
        protected string Name { get; set; }
        protected string Address { get; set; }

        public Employee(string name, string address)
        {
            Name = name;
            Address = address; 
        }

      
   

    }
}
