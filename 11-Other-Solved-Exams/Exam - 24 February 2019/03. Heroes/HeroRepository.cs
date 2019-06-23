using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private Dictionary<string, Hero> data;

        public HeroRepository()
        {
            data = new Dictionary<string, Hero>();
        }

        public void Add(Hero hero)
        {
            data.Add(hero.Name, hero);
        }

        public void Remove(string name)
        {
            if (data.ContainsKey(name))
            {
                data.Remove(name);
            }
        }

        public Hero GetHeroWithHighestStrength()
        {
            Hero heroWithHighestStrength = null;
            int highestStrength = 0;

            foreach (var hero in data.Values)
            {
                if (hero.Item.Strength > highestStrength)
                {
                    highestStrength = hero.Item.Strength;
                    heroWithHighestStrength = hero;
                }
            }
            return heroWithHighestStrength;
        }

        public Hero GetHeroWithHighestAbility()
        {
            Hero heroWithHighestAbility = null;
            int highestAbility = 0;

            foreach (var hero in data.Values)
            {
                if (hero.Item.Ability > highestAbility)
                {
                    highestAbility = hero.Item.Ability;
                    heroWithHighestAbility = hero;
                }
            }
            return heroWithHighestAbility;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            Hero heroWithHighestIntelligence = null;
            int highestIntelligence = 0;

            foreach (var hero in data.Values)
            {
                if (hero.Item.Intelligence > highestIntelligence)
                {
                    highestIntelligence = hero.Item.Intelligence;
                    heroWithHighestIntelligence = hero;
                }
            }
            return heroWithHighestIntelligence;
        }

        public int Count => data.Count;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var hero in data.Values)
            {
                sb.Append(hero.ToString());
            }

            return sb.ToString();
        }
    }
}
