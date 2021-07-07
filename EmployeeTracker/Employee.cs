﻿using System;
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

        public virtual Employee CreateEmployee()
        {
            Console.Clear();

            //Header
            Console.WriteLine("====================");
            Console.WriteLine($"Add Employee");
            Console.WriteLine("====================\r\n");


            Console.Write("Employee Name: ");
            string employeeName = Validation.StringValidation(Console.ReadLine());

            Console.Write("Employee Location(City, State): ");
            string employeelocation = Validation.StringValidation(Console.ReadLine());

            Console.Write("Employee Hourly Rate: ");
            decimal hourlyRate = Validation.DecimalValidation(Console.ReadLine());

            Console.Write("Hours Per Week: ");
            decimal weekHours = Validation.DecimalValidation(Console.ReadLine());


            Employee employee = new PartTime(employeeName, employeelocation, hourlyRate, weekHours);

            return employee;


        }



    }
}
