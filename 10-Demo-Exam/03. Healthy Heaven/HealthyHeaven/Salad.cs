using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HealthyHeaven
{
    public class Salad
    {
        private readonly IList<Vegetable> salad;

        public string Name { get; private set; }

        public Salad(string name)
        {
            Name = name;
            salad = new List<Vegetable>();
        }

        public int GetTotalCalories()
        {
            int totalCalories = 0;

            foreach (var vegetable in salad)
            {
                totalCalories += vegetable.Calories;
            }
            return totalCalories;
        }

        public int GetProductCount()
        {
            int productCount = salad.Count;
            return productCount;
        }
        public void Add(Vegetable product)
        {
            salad.Add(product);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"* Salad {Name} is {GetTotalCalories()} calories and have {GetProductCount()} products:");
            foreach (var vegetable in salad)
            {
                sb.AppendLine(vegetable.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
