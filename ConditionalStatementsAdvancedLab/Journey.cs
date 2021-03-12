using System;

namespace Journey
{
    class Journey
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double moneySpent = 0.00;
            string accomodation = string.Empty;
            string destination = string.Empty;


            if (budget <= 100)
            {
                destination = "Bulgaria";
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
            }
            else if (budget > 1000)
            {
                destination = "Europe";
            }

            if (destination == "Bulgaria" && season == "summer")
            {
                accomodation = "Camp";
                moneySpent = budget - (budget * 0.70);
            }

            else if (destination == "Bulgaria" || season == "Winter")
            {
                accomodation = "Hotel";
                moneySpent = budget - (budget * 0.30);
            }
            if (destination == "Balkans" && season == "summer")
            {
                accomodation = "Camp";
                moneySpent = budget - (budget * 0.60);
            }

            else if (destination == "Balkans" || season == "Winter")
            {
                accomodation = "Hotel";
                moneySpent = budget - (budget * 0.20);
            }
            if (destination == "Europe")
            {
                accomodation = "Hotel";
                moneySpent = budget * 0.90;
            }


            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{accomodation} - {moneySpent:f2}");
        }
    }
}
