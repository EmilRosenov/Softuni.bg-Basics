using System;

namespace EasterParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGUests = int.Parse(Console.ReadLine()); 
            double pricePerPerson = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double discountPerPerson = 0;

            // if (budget +) :"It is party time! {останали пари} leva left."
            // else (budget -) :"No party! {недостигащи пари} leva needed."
            if (numberOfGUests<10)
            {
                discountPerPerson = pricePerPerson;
            }
            else if (numberOfGUests >= 10 && numberOfGUests <= 15)
            {
                discountPerPerson = pricePerPerson * 0.85;
                
            }
            else if (numberOfGUests > 15 && numberOfGUests <= 20)
            {
                discountPerPerson = pricePerPerson * 0.80;
            }
            else if (numberOfGUests > 20)
            {
                discountPerPerson = pricePerPerson * 0.75;
            }

            //double totalPricePerPerson = pricePerPerson - discountPerPerson;
            double costForGuests = numberOfGUests * discountPerPerson;

            double costsForCake = budget * 0.1;

            double totalCosts = costForGuests + costsForCake;

            if (budget >= totalCosts)
            {
                double moneyLeft = budget - totalCosts;
                Console.WriteLine($"It is party time! {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = Math.Abs(budget - totalCosts);
                Console.WriteLine($"No party! {moneyNeeded:f2} leva needed.");
            }
        }
    }
}
