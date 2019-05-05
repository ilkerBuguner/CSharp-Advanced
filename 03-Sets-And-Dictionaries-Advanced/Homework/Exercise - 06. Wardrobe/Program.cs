using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int timesToRead = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();


            for (int i = 0; i < timesToRead; i++)
            {
                string[] colorAndClothes = Console.ReadLine().Split(" -> ");
                string color = colorAndClothes[0];
                string[] clothes = colorAndClothes[1].Split(',');

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    string currentCloth = clothes[j];

                    if (!wardrobe[color].ContainsKey(currentCloth))
                    {
                        wardrobe[color][currentCloth] = 0;
                    }

                    wardrobe[color][currentCloth]++;
                }
            }

            string[] colorAndItemToFind = Console.ReadLine().Split();
            string colorToFind = colorAndItemToFind[0];
            string itemToFind = colorAndItemToFind[1];

            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var cloth in item.Value)
                {
                    if (item.Key == colorToFind && cloth.Key == itemToFind)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
