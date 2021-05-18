using System;

namespace EasterLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalCost = 0;
            double cosunac = 3.20;
            double eggs12 = 4.35;
            double cookiesPricePerKG = 5.40;
            double eggPaintForAnEgg = 0.15;

            int numberCosunacs = int.Parse(Console.ReadLine());
            int dozensOfEggs = int.Parse(Console.ReadLine());
            int kgsCookies = int.Parse(Console.ReadLine());

            double moneyForCosunacs = numberCosunacs * cosunac;
            double moneyForEggs = dozensOfEggs * eggs12;
            double moneyForCookies = cookiesPricePerKG * kgsCookies;
            double moneyForEggPaint = dozensOfEggs * 12 * eggPaintForAnEgg;

            totalCost = moneyForCosunacs + moneyForEggs + moneyForCookies + moneyForEggPaint;

            Console.WriteLine($"{totalCost:f2}");
        }
    }
}
