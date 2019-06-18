using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyHeaven
{
    public class Restaurant
    {
        private readonly IList<Salad> data;
        public string Name { get; private set; }

        public Restaurant(string name)
        {
            Name = name;
            data = new List<Salad>();
        }

        public void Add(Salad salad)
        {
            data.Add(salad);
        }

        public bool Buy(string name)
        {
            if (data.FirstOrDefault(x => x.Name == name) == null)
            {
                return false;
            }
            else
            {
                data.Remove(data.FirstOrDefault(x => x.Name == name));
                return true;
            }
        }

        public Salad GetHealthiestSalad()
        {
            int minCalsSalad = data.Min(x => x.GetTotalCalories());
            return this.data.FirstOrDefault(x => x.GetTotalCalories() == minCalsSalad);
        }

        public string GenerateMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} have {data.Count} salads:");
            foreach (var salad in data)
            {
                sb.AppendLine(salad.ToString());
            }
            return sb.ToString().TrimEnd();
        }

    }
}
