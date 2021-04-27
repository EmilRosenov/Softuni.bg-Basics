using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double taxPerYear = double.Parse(Console.ReadLine());

            double totalCost = 0;
            double costForShoes = taxPerYear * 0.6;
            double costForKit = costForShoes * 0.8;
            double costForBall = costForKit * 0.25;
            double costForAccessories = costForBall * 0.2;

            totalCost = taxPerYear + costForShoes + costForKit + costForBall + costForAccessories;
            Console.WriteLine($"{totalCost:f2}");
        }
    }
}
