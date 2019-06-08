using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            int timesToRead = int.Parse(Console.ReadLine());

            var employees = new Dictionary<string, List<Employee>>();

            for (int i = 0; i < timesToRead; i++)
            {
                var employeeInfo = Console.ReadLine().Split();

                string name = employeeInfo[0];
                double salary = double.Parse(employeeInfo[1]);
                string position = employeeInfo[2];
                string department = employeeInfo[3];
                string email = "n/a";
                int age = -1;

                if (employeeInfo.Length > 4)
                {
                    if (employeeInfo[4].Contains("@"))
                    {
                        email = employeeInfo[4];
                    }
                    else
                    {
                        age = int.Parse(employeeInfo[4]);
                    }
                }
                if (employeeInfo.Length == 6)
                {
                    if (employeeInfo[5].Contains("@"))
                    {
                        email = employeeInfo[5];
                    }
                    else
                    {
                        age = int.Parse(employeeInfo[5]);
                    }
                }

                if (!employees.ContainsKey(department))
                {
                    employees[department] = new List<Employee>();
                }

                employees[department].Add(new Employee(name, salary, position, department, email, age));

            }

            double maxAverageSalary = 0;
            string highestSalaryDepartment = "";

            foreach (var department in employees)
            {
                if (department.Value.Average(x => x.Salary) > maxAverageSalary)
                {
                    maxAverageSalary = department.Value.Average(x => x.Salary);
                    highestSalaryDepartment = department.Key;
                }
            }

            Console.WriteLine($"Highest Average Salary: {highestSalaryDepartment}");

            foreach (var employee in employees[highestSalaryDepartment].OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
        }
    }
}
