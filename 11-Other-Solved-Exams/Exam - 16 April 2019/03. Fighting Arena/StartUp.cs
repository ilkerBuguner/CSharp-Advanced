using System;


namespace FightingArena
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Arena arena = new Arena("Armeec");

            Stat firstGladiatorStat = new Stat(20, 25, 35, 14, 48);
            Stat secondGladiatorStat = new Stat(40, 40, 40, 40, 40);
            Stat thirdGladiatorStat = new Stat(20, 25, 35, 14, 48);

            //Creates weapons
            Weapon firstGlariatorWeapon = new Weapon(5, 28, 100);
            Weapon secondGlariatorWeapon = new Weapon(5, 28, 100);
            Weapon thirdGlariatorWeapon = new Weapon(50, 50, 50);

            //Creates gladiators
            Gladiator firstGladiator = new Gladiator("Stoyan", firstGladiatorStat, firstGlariatorWeapon);
            Gladiator secondGladiator = new Gladiator("Pesho", secondGladiatorStat, secondGlariatorWeapon);
            Gladiator thirdGladiator = new Gladiator("Gosho", thirdGladiatorStat, thirdGlariatorWeapon);

            //Adds gladiators to arena
            arena.Add(firstGladiator);
            arena.Add(secondGladiator);
            arena.Add(thirdGladiator);

            //Prints gladiators count at the arena
            Console.WriteLine(arena.Count);

            //Gets strongest gladiator and print him
            Gladiator strongestGladiator = arena.GetGladitorWithHighestTotalPower();
            Console.WriteLine(strongestGladiator);

            //Gets gladiator with the strongest weapon and print him
            Gladiator bestWeaponGladiator = arena.GetGladitorWithHighestWeaponPower();
            Console.WriteLine(bestWeaponGladiator);

            //Gets gladiator with the strongest stat and print him
            Gladiator bestStatGladiator = arena.GetGladitorWithHighestStatPower();
            Console.WriteLine(bestStatGladiator);

            //Removes gladiator
            arena.Remove("Gosho");

            //Prints gladiators count at the arena
            Console.WriteLine(arena.Count);

            //Prints the arena
            Console.WriteLine(arena);

        }
    }
}
