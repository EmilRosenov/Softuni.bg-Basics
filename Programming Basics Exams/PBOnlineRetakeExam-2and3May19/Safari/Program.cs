using System;

namespace Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double fuel = 2.10;
            double guidePrice = 100;
            double totalAfterDiscount = 0;

            double budget = double.Parse(Console.ReadLine());
            double litersFuel = double.Parse(Console.ReadLine());
            string dayOfTheWeek = Console.ReadLine();

            double totalPriceFuel = fuel * litersFuel;
            double totalPriceAllCosts = guidePrice + totalPriceFuel;

            if (dayOfTheWeek =="Saturday")
            {
                totalAfterDiscount = totalPriceAllCosts * 0.9;
            }
            else if (dayOfTheWeek=="Sunday")
            {
                totalAfterDiscount = totalPriceAllCosts * 0.8;
            }

            if (budget >= totalAfterDiscount)
            {
                double moneyLeft = budget - totalAfterDiscount;
                Console.WriteLine($"Safari time! Money left: {moneyLeft:f2} lv.");
            }
            else
            {
                double moneyNeeded = totalAfterDiscount - budget;
                Console.WriteLine($"Not enough money! Money needed: {moneyNeeded:f2} lv.");
            }
        }
    }
}
