using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab___1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int sum = 0;

            int[,] matrix = new int[info[0], info[1]];

            for (int i = 0; i < info[0]; i++)
            {
                var array = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < array.Length; j++)
                {
                    sum += array[j];
                }
            }

            Console.WriteLine(info[0]);
            Console.WriteLine(info[1]);
            Console.WriteLine(sum);
        }
    }
}
