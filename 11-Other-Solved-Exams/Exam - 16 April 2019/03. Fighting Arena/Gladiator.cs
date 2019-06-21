using System;
using System.Collections.Generic;
using System.Text;

namespace FightingArena
{
    public class Gladiator
    {
        public string Name { get; set; }
        public Stat Stat { get; set; }
        public Weapon Weapon { get; set; }

        public Gladiator()
        {

        }
        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            Name = name;
            Stat = stat;
            Weapon = weapon;
        }

        public int GetStatPower()
        {
            int statPower = Stat.Strength + Stat.Flexibility + Stat.Agility + Stat.Skills + Stat.Intelligence;
            return statPower;
        }

        public int GetWeaponPower()
        {
            int weaponPower = Weapon.Size + Weapon.Solidity + Weapon.Sharpness;
            return weaponPower;
        }

        public int GetTotalPower()
        {
            int totalPower = GetStatPower() + GetWeaponPower();
            return totalPower;
        }

        public override string ToString()
        {
            int totalPower = GetTotalPower();
            int weaponPower = GetWeaponPower();
            int statPower = GetStatPower();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"[{Name}] - [{totalPower}]");
            sb.AppendLine($"  Weapon Power: [{weaponPower}]");
            sb.AppendLine($"  Stat Power: [{statPower}]");
            return sb.ToString();
        }
    }
}
