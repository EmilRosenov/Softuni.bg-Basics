using System;

namespace poolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            double people = double.Parse(Console.ReadLine());
            double entranceFee = double.Parse(Console.ReadLine());
            double priceSunbed = double.Parse(Console.ReadLine());
            double priceUmbrella = double.Parse(Console.ReadLine());

            double total = 0;

            double totalEntryFee = people * entranceFee;
            double numberUmbrellas = Math.Ceiling(people / 2);
            double totalUmbrella = priceUmbrella * numberUmbrellas;
            double numberSunbed = Math.Ceiling(people * 0.75);
            double totalSunbed = numberSunbed * priceSunbed;

            double totalCosts = totalEntryFee + totalUmbrella + totalSunbed;
            Console.WriteLine($"{totalCosts:f2} lv.");
        }
    }
}
