using System;

namespace TennisEqupment
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfTennisRocket = double.Parse(Console.ReadLine());
            int numberTennisRockets = int.Parse(Console.ReadLine());
            int numberPairShoes = int.Parse(Console.ReadLine());

            double pricePairShoes = priceOfTennisRocket / 6;
            double totalCostShoes = numberPairShoes * pricePairShoes;
            double totalCostTennisRocket = priceOfTennisRocket * numberTennisRockets;

            double costEquipment = (totalCostTennisRocket + totalCostShoes) * 0.2;
            double total = totalCostShoes + totalCostTennisRocket + costEquipment;

            double priceDjokovic = total * 0.125;
            double priceSponsors = total * 0.875;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(priceDjokovic)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(priceSponsors)}");
        }
    }
}
