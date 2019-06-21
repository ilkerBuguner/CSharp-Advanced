using System;
using System.Collections.Generic;
using System.Text;

namespace FightingArena
{
    public class Arena
    {
        private readonly Dictionary<string, Gladiator> arena;
        public string Name { get; set; }
        public int Count => arena.Count;
        public Arena(string name)
        {
            Name = name;
            arena = new Dictionary<string, Gladiator>();
        }

        public void Add(Gladiator gladiator)
        {
            arena.Add(gladiator.Name, gladiator);
        }
        public void Remove(string name)
        {
            if (arena.ContainsKey(name))
            {
                arena.Remove(name);
            }
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            Gladiator gladiatorWithHighestStats = new Gladiator();
            int highestStat = 0;
            foreach (var gladiator in arena.Values)
            {
                if (gladiator.GetStatPower() > highestStat)
                {
                    gladiatorWithHighestStats = gladiator;
                }
            }
            return gladiatorWithHighestStats;
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            Gladiator highestWeaponPowerGladiator = new Gladiator();
            int highestWeaponPower = 0;
            foreach (var gladiator in arena.Values)
            {
                if (gladiator.GetWeaponPower() > highestWeaponPower)
                {
                    highestWeaponPowerGladiator = gladiator;
                }
            }
            return highestWeaponPowerGladiator;
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            Gladiator highestTotalPowerGladiator = new Gladiator();
            int highestTotalPower = 0;
            foreach (var gladiator in arena.Values)
            {
                if (gladiator.GetTotalPower() > highestTotalPower)
                {
                    highestTotalPowerGladiator = gladiator;
                }
            }
            return highestTotalPowerGladiator;
        }

        public override string ToString()
        {
            return $"[{Name}] - [{Count}] gladiators are participating.";
        }
    }
}
