using System;

namespace EasterGuests
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfGuests = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double cosunacPrice = 4.00;
            double eggPrice = 0.45;

            double numberOfCosunacNeeded = Math.Ceiling(numberOfGuests / 3);
            double costForCosunacs = numberOfCosunacNeeded * cosunacPrice;
            double eggsNeeded = numberOfGuests * 2;
            double costForEggs = eggPrice * eggsNeeded;

            double totalCost = costForCosunacs + costForEggs;

            if (budget>= totalCost)
            {
                double moneyLeft = budget - totalCost;
                Console.WriteLine($"Lyubo bought {numberOfCosunacNeeded} Easter bread and {eggsNeeded} eggs.");
                Console.WriteLine($"He has {moneyLeft:f2} lv. left.");
            }
            else
            {
                double moneyNeeded = Math.Abs(budget - totalCost);
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {moneyNeeded:f2} lv. more.");
            }

            //if :  "Lyubo bought {брои закупени козунаци} Easter bread and {брои закупени яйца} eggs."
            //      "He has {останали пари} lv. left."  
            //else:	"Lyubo doesn't have enough money."
            //      "He needs {недостигащи пари} lv. more."
        }
    }
}
