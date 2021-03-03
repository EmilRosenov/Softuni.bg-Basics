using System;

namespace ToyShop
{
    class ToyShop
    {
        static void Main(string[] args)
        {
            double travelCost = double.Parse(Console.ReadLine());
            //⦁	Брой пъзели -цяло число в интервала[0… 1000]
            int puzzleCount = int.Parse(Console.ReadLine());
            //⦁	Брой говорещи кукли - цяло число в интервала[0 … 1000]
            int dollsCount = int.Parse(Console.ReadLine());
            //⦁	Брой плюшени мечета - цяло число в интервала[0 … 1000]
            int teddyBearsCount = int.Parse(Console.ReadLine());
            //⦁	Брой миньони -цяло число в интервала[0 … 1000]
            int minionsCount = int.Parse(Console.ReadLine());
            //⦁	Брой камиончета -цяло число в интервала[0 … 1000]
            int trucksCount = int.Parse(Console.ReadLine());


            double MoneyPuzzles = puzzleCount * 2.6;
            double moneyDolls = dollsCount * 3;
            double moneyBears = teddyBearsCount * 4.1;
            double moneyMinions = minionsCount * 8.2;
            double moneyTrucks = trucksCount * 2;
            double totalMoney = MoneyPuzzles + moneyDolls + moneyBears + moneyMinions + moneyTrucks;

            double totalToysCount = trucksCount + minionsCount + teddyBearsCount + dollsCount + puzzleCount;

            if (totalToysCount >= 50)
            {
                totalMoney = totalMoney * 0.75;
            }

            totalMoney = totalMoney * 0.9;






            //На конзолата се отпечатва:
            //⦁	Ако парите са достатъчни се отпечатва:
            //⦁	"Yes! {оставащите пари} lv left."
            if (totalMoney >= travelCost)
            {
                double remainingMoney = totalMoney - travelCost;
                Console.WriteLine($"Yes! {remainingMoney:F2} lv left.");
            }
            //⦁	Ако парите НЕ са достатъчни се отпечатва:
            else if (travelCost > totalMoney)
            {
                double neededMoney = travelCost - totalMoney;
                Console.WriteLine($"Not enough money! {neededMoney:F2} lv needed.");
            }
            //⦁	"Not enough money! {недостигащите пари} lv needed
            //Резултатът трябва да се форматира до втория знак след десетичната запетая.

        }
    }
}
