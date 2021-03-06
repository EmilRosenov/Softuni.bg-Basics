using System;

namespace GodzillaVs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statistsNum = int.Parse(Console.ReadLine());
            double outfitPrice = double.Parse(Console.ReadLine());


            double totalOutfitMoney = outfitPrice * statistsNum;

            double decorMoney = budget * 0.1;

            if (statistsNum > 150)
            {
                totalOutfitMoney = totalOutfitMoney - (0.10 * totalOutfitMoney);
            }

            double totalCost = decorMoney + totalOutfitMoney;
            double difference = budget - totalCost;

            if (budget >= totalCost)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with " + $"{difference:f2} leva left.");
            }

            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(difference):f2} leva more.");
            }
        }
    }
}
