using System;

namespace FishingBoat
{
    class FishingBoat
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            if (season == "Spring")
            {

                totalPrice = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                totalPrice = 4200;
            }
            else if (season == "Winter")
            {
                totalPrice = 2600;
            }
            if (fishermen <= 6)
            {
                totalPrice *= 0.9;
            }
            else if (fishermen >= 7 && fishermen <= 11)
            {
                totalPrice *= 0.85;
            }
            else
            {
                totalPrice *= 0.75;
            }
            if (season == "Spring" || season == "Summer" || season == "Winter")
            {
                if (fishermen % 2 == 0)
                {
                    totalPrice *= 0.95;
                }
            }

            double moneyLeft = budget - totalPrice;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(moneyLeft):f2} leva.");
            }


        }
    }
}
