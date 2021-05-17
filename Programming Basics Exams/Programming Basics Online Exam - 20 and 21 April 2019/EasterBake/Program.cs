using System;

namespace EasterBake
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfCosunacs = double.Parse(Console.ReadLine());

            double currentamountOfSugarUsed = 0;
            double currentamountOfFlourUsed = 0;
            double maxAmountOfSugarUsed = 0;
            double maxAmountOfFlourUsed = 0;
            double totalAmountSugar = 0;
            double totalAmountFlour = 0;

            for (int i = 1; i <= numberOfCosunacs; i++)
            {
                double amountOfSugarUsed = double.Parse(Console.ReadLine()); 
                double amountOfFlourUsed = double.Parse(Console.ReadLine());


                totalAmountSugar += amountOfSugarUsed;
                totalAmountFlour += amountOfFlourUsed;



                if (amountOfSugarUsed> currentamountOfSugarUsed)
                {
                    maxAmountOfSugarUsed = amountOfSugarUsed;
                    currentamountOfSugarUsed = maxAmountOfSugarUsed;
                }
                if (amountOfFlourUsed > currentamountOfFlourUsed)
                {
                    maxAmountOfFlourUsed = amountOfFlourUsed;
                    currentamountOfFlourUsed = maxAmountOfFlourUsed;
                }

            }

            double packsSugarNeeded = totalAmountSugar / 950;
            double packsFlourNeeded = totalAmountFlour / 750;

            Console.WriteLine($"Sugar: {Math.Ceiling(packsSugarNeeded)}");
            Console.WriteLine($"Flour: {Math.Ceiling(packsFlourNeeded)}");
            Console.WriteLine($"Max used flour is {maxAmountOfFlourUsed} grams, max used sugar is {maxAmountOfSugarUsed} grams.");
        }
    }
}
