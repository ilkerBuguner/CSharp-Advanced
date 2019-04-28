using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab___02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, List<double>>();

            for (int i = 0; i < number; i++)
            {
                string[] studentInfo = Console.ReadLine().Split();

                string studentName = studentInfo[0];
                double studentGrade = double.Parse(studentInfo[1]);

                if (!dict.ContainsKey(studentName))
                {
                    dict[studentName] = new List<double>();
                }

                dict[studentName].Add(studentGrade);
            }

            foreach (var kvp in dict)
            {
                Console.Write($"{kvp.Key} -> ");

                foreach (var grade in kvp.Value)
                {
                    Console.Write($"{grade:F2} ");
                }

                Console.WriteLine($"(avg: {kvp.Value.Average():F2})");
            }
        }
    }
}
