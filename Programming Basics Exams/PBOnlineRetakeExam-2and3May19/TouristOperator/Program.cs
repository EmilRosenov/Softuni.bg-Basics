using System;

namespace TouristOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            double numberItemsBought = 0;
            double totalPriceItemsBought = 0;
            double moneyNeeded = 0;
            bool isBudgetEnough = true;


            while (input != "Stop")
            {
                
                double priceOfProduct = double.Parse(Console.ReadLine());

                if (priceOfProduct > budget)
                {
                    moneyNeeded = priceOfProduct - budget;
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {moneyNeeded:f2} leva!");
                    return;
                }

                numberItemsBought++;
               
                   
                if (numberItemsBought % 3==0)
                {
                    priceOfProduct *= 0.5;
                }

                budget -= priceOfProduct;
                totalPriceItemsBought += priceOfProduct;

                input = Console.ReadLine();
            }
            
             if (isBudgetEnough)
             {
             Console.WriteLine($"You bought {numberItemsBought} products for {totalPriceItemsBought:f2} leva.");
             }
           
        }
    }
}
