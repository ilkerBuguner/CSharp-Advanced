using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Employee
    {
        private string name;
        private double salary;
        private string position;
        private string department;
        private string email;
        private int age;

        public string Name { get; set; }
        public double Salary { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public Employee()
        {
            Email = "n/a";
            Age = -1;
        }

        public Employee(string name, double salary, string position, string department, string email = "n/a", int age = -1)
        {
            Name = name;
            Salary = salary;
            Position = position;
            Department = department;
            Email = email;
            Age = age;
        }
    }
}
