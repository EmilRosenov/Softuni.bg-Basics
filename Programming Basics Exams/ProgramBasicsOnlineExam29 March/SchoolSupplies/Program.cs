using System;

namespace SchoolSupplies
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberPenPacks = double.Parse(Console.ReadLine());
            double numberMarkerPacks = double.Parse(Console.ReadLine());
            double cleningBoardChemical = double.Parse(Console.ReadLine());
            double discountPercentage = double.Parse(Console.ReadLine());

            double penPacksPrice = 5.80;
            double markersPacksPrice = 7.20;
            double cleningBoardChemicalPrice = 1.20;

            double price = (numberPenPacks * penPacksPrice) +
                           (numberMarkerPacks* markersPacksPrice) + 
                           (cleningBoardChemical* cleningBoardChemicalPrice);

            double disount = price * discountPercentage / 100;
            double total = price - disount;
            Console.WriteLine($"{total:f3}");

        }
    }
}
