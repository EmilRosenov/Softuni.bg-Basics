using System;

namespace shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countVideoCards = int.Parse(Console.ReadLine());
            int countProcessors = int.Parse(Console.ReadLine());
            int countRamSlots = int.Parse(Console.ReadLine());

            double difference = 0;
            double discount = 0;



            double totalPriceVideoCard = countVideoCards * 250;
            double totalPriceProcessor = countProcessors * (totalPriceVideoCard * 0.35);
            double totalPriceRamSlots = totalPriceVideoCard * 0.1* countRamSlots;

            double totalCost = totalPriceVideoCard + totalPriceProcessor + totalPriceRamSlots;

            if (countVideoCards > countProcessors)
            {
                discount = totalCost - totalCost * 0.85;
                totalCost -= discount;
            }

            if (budget >= totalCost)
            {
                difference = budget - totalCost;
                Console.WriteLine($"You have {difference:f2} leva left!");
            }
            else
            {
                difference = totalCost-budget;
                Console.WriteLine($"Not enough money! You need {difference:f2} leva more!");
            }
        }
    }
}
