using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab___07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> normalGuests = new HashSet<string>();

            while (true)
            {
                string guest = Console.ReadLine();

                if (guest == "PARTY")
                {
                    break;
                }

                if (char.IsDigit(guest[0]))
                {
                    vipGuests.Add(guest);
                }
                else
                {
                    normalGuests.Add(guest);
                }
            }

            int missingGuests = vipGuests.Count + normalGuests.Count;

            while (true)
            {
                string comingGuest = Console.ReadLine();

                if (comingGuest == "END")
                {
                    break;
                }

                if (vipGuests.Contains(comingGuest))
                {
                    vipGuests.Remove(comingGuest);
                    missingGuests--;
                }

                if (normalGuests.Contains(comingGuest))
                {
                    normalGuests.Remove(comingGuest);
                    missingGuests--;
                }
            }

            Console.WriteLine(missingGuests);
            if (vipGuests.Any())
            {
                foreach (var guest in vipGuests)
                {
                    Console.WriteLine(guest);
                }
            }
            if (normalGuests.Any())
            {
                foreach (var guest in normalGuests)
                {
                    Console.WriteLine(guest);
                }
            }
        }
    }
}
