using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab___03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Revision")
                {
                    break;
                }

                string[] info = line.Split(", ");

                string shopName = info[0];
                string productName = info[1];
                double price = double.Parse(info[2]);

                if (!dict.ContainsKey(shopName))
                {
                    dict[shopName] = new Dictionary<string, double>();
                }

                dict[shopName].Add(productName, price);
            }

            foreach (var shop in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
