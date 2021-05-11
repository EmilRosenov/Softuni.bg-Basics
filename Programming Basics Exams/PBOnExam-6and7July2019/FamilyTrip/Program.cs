using System;

namespace FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double nightsStay = double.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            double percentageAdditionalCost = double.Parse(Console.ReadLine());

            if (nightsStay > 7)
            {
                pricePerNight *= 0.95;
            }

            double totalCostForNights = nightsStay * pricePerNight;
            double additionalCost = budget * percentageAdditionalCost / 100;

            double allCost = totalCostForNights + additionalCost;

            if (budget >= allCost)
            {
                Console.WriteLine($"Ivanovi will be left with {(budget-allCost):f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{(allCost-budget):f2} leva needed.");
            }
        }
    }
}
