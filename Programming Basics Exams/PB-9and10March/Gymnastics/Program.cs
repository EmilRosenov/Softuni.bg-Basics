using System;

namespace Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string item = Console.ReadLine();
            double level = 0;
            double performance = 0;
            double total = 0;

            if (country == "Russia")
            {
                if (item == "ribbon")
                {
                    level = 9.100;
                    performance = 9.400;
                    total = level + performance;
                }
                else if (item == "hoop")
                {
                    level = 9.300;
                    performance = 9.800;
                    total = level + performance;
                }
                else if (item == "rope")
                {
                    level = 9.600;
                    performance = 9.000;
                    total = level + performance;
                }
            }
            else if (country == "Bulgaria")
            {
                if (item == "ribbon")
                {
                    level = 9.600;
                    performance = 9.400;
                    total = level + performance;
                }
                else if (item == "hoop")
                {
                    level = 9.550;
                    performance = 9.750;
                    total = level + performance;
                }
                else if (item == "rope")
                {
                    level = 9.500;
                    performance = 9.400;
                    total = level + performance;
                }
            }
            else if (country == "Italy")
            {
                if (item == "ribbon")
                {
                    level = 9.200;
                    performance = 9.500;
                    total = level + performance;
                }
                else if (item == "hoop")
                {
                    level = 9.450;
                    performance = 9.350;
                    total = level + performance;
                }
                else if (item == "rope")
                {
                    level = 9.700;
                    performance = 9.150;
                    total = level + performance;
                }
            }

            Console.WriteLine($"The team of {country} get {total:f3} on {item}.");
            double pointsNeeded = 20 - total;
            double percentage = pointsNeeded / 20 * 100;
            Console.WriteLine($"{percentage:f2}%");
        }
    }
}
