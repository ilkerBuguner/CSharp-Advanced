using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    class DateModifier
    {
        private DateTime date1;
        private DateTime date2;

        public DateModifier()
        {

        }

        public double CalculateDayDifferenceBetweenTwoDates(string date1, string date2)
        {
            string[] tokens1 = date1.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] tokens2 = date2.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            this.date1 = new DateTime(int.Parse(tokens1[0]), int.Parse(tokens1[1]), int.Parse(tokens1[2]));
            this.date2 = new DateTime(int.Parse(tokens2[0]), int.Parse(tokens2[1]), int.Parse(tokens2[2]));

            return Math.Abs((this.date2 - this.date1).TotalDays);
        }
    }
}
