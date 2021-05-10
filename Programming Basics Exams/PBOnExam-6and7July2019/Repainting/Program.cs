using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalCostsWithoutManHours = 0;

            double pricePolliester = 1.50;
            double pricePaintPerL = 14.50;
            double PricePaintThinnerPerL = 5.00;

            double pollyesterNeededM2 = double.Parse(Console.ReadLine());
            double paintNeededL = double.Parse(Console.ReadLine());
            double paintThinnerNeededL = double.Parse(Console.ReadLine());

            double manHours = double.Parse(Console.ReadLine());

            double totalPolliesterCost = (pollyesterNeededM2 + 2) * pricePolliester;
            double totalPaintCost = pricePaintPerL * paintNeededL + (pricePaintPerL * paintNeededL) * 0.10;
            double totalPaintThinnerPrice = paintThinnerNeededL * PricePaintThinnerPerL;
            double bags = 0.4;

            totalCostsWithoutManHours = totalPolliesterCost + totalPaintCost + totalPaintThinnerPrice + bags;
            double costForWork = (totalCostsWithoutManHours * 0.3) * manHours;

            double total = totalCostsWithoutManHours + costForWork;
            Console.WriteLine($"Total expenses: {total:f2} lv.");
        }
    }
}
