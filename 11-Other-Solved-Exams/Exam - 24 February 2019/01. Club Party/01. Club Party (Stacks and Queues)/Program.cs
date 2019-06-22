using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Club_Party__Stacks_and_Queues_
{
    class Program
    {
        static void Main(string[] args)
        {
            int hallsCapacity = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            Queue<char> halls = new Queue<char>();
            Dictionary<char, List<int>> dict = new Dictionary<char, List<int>>();
            char currentHall;
            int currentReservation;
            int reservationSum = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                bool isletter = char.TryParse(input[i], out currentHall);
                if (isletter && char.IsLetter(currentHall))
                {
                    halls.Enqueue(currentHall);
                }
                else
                {
                    if (halls.Any())
                    {
                        char currentHalll = halls.Peek();
                        currentReservation = int.Parse(input[i]);
                        if (currentReservation + reservationSum <= hallsCapacity)
                        {
                            reservationSum += currentReservation;
                            
                            if (!dict.ContainsKey(currentHalll))
                            {
                                dict[currentHalll] = new List<int>();
                            }
                            dict[currentHalll].Add(currentReservation);
                        }
                        else
                        {
                            halls.Dequeue();
                            reservationSum = 0;
                            Console.WriteLine($"{currentHalll} -> {string.Join(", ", dict[currentHalll])}");
                            if (halls.Any())
                            {
                                if (currentReservation + reservationSum <= hallsCapacity)
                                {
                                    reservationSum += currentReservation;
                                    char currentHall2 = halls.Peek();
                                    if (!dict.ContainsKey(currentHall2))
                                    {
                                        dict[currentHall2] = new List<int>();
                                    }
                                    dict[currentHall2].Add(currentReservation);
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
