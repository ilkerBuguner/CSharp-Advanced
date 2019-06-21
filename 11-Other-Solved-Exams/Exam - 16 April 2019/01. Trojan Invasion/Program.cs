using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Trojan_Invasion__Stacks_And_Queues_Exam_Ex_
{
    class Program
    {
        static void Main(string[] args)
        {
            int trojanWaves = int.Parse(Console.ReadLine());
            int[] plates = Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray();
            Stack<int> spartanPlates = new Stack<int>(plates);
            bool didTrojansWon = false;
            Stack<int> warriorsLeft = new Stack<int>();
            int counter = 0;

            for (int i = 1; i <= trojanWaves; i++)
            {
                int[] currentWave = Console.ReadLine().Split().Select(int.Parse).ToArray();
                Stack<int> wave = new Stack<int>(currentWave);

                if (i % 3 == 0)
                {
                    Queue<int> temp = new Queue<int>();
                    int spartan = int.Parse(Console.ReadLine());
                    while (spartanPlates.Count() > 0)
                    {
                        temp.Enqueue(spartanPlates.Pop());
                    }
                    temp.Enqueue(spartan);

                    spartanPlates = new Stack<int>(temp.Reverse());
                    temp = new Queue<int>();
                }


                while (spartanPlates.Any() && wave.Any())
                {
                    if (spartanPlates.Peek() < wave.Peek())
                    {
                        int leftHpOfTheWarrior = wave.Pop() - spartanPlates.Pop();
                        wave.Push(leftHpOfTheWarrior);
                    }
                    else if (spartanPlates.Peek() > wave.Peek())
                    {
                        int platesHp = spartanPlates.Pop() - wave.Pop();
                        spartanPlates.Push(platesHp);
                    }
                    else if (spartanPlates.Peek() == wave.Peek())
                    {
                        spartanPlates.Pop();
                        wave.Pop();
                    }
                }


                if (spartanPlates.Count <= 0)
                {
                    didTrojansWon = true;
                    if (counter == 0)
                    {
                        warriorsLeft = wave;
                        counter++;
                    }
                }
            }

            if (didTrojansWon == false)
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", spartanPlates)}");
            }
            else if (didTrojansWon == true)
            {
                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                Console.WriteLine($"Warriors left: {string.Join(", ", warriorsLeft)}");
            }
        }
    }
}
