using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        private readonly List<Astronaut> data;
        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count => data.Count;
        public SpaceStation(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Astronaut>();
        }

        public void Add(Astronaut astronaut)
        {
            if (data.Count < Capacity)
            {
                data.Add(astronaut);
            }
        }

        public bool Remove(string name)
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

        public Astronaut GetOldestAstronaut()
        {
            Astronaut oldestAstronaut = data.OrderByDescending(x => x.Age).First();
            return oldestAstronaut;
        }

        public Astronaut GetAstronaut(string name)
        {
            Astronaut getAstronaut = data.FirstOrDefault(x => x.Name == name);
            return getAstronaut;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Astronauts working at Space Station {Name}:");
            foreach (var astronaut in data)
            {
                sb.AppendLine(astronaut.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
