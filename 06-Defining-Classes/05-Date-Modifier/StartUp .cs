using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            DateModifier daysDiff = new DateModifier();

            double daysDifference = daysDiff.CalculateDayDifferenceBetweenTwoDates(date1, date2);

            Console.WriteLine(daysDifference);

        }
    }
}
