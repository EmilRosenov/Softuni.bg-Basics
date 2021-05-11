using System;

namespace Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double profitWanted = double.Parse(Console.ReadLine());
            double currentProfit = 0;
           

            string command = Console.ReadLine();

            while (command !="Party!")
            {
               


                int cocktailNumber = int.Parse(Console.ReadLine());
                double priceForCurrentCocktail = 0;
                for (int i = 0; i < cocktailNumber; i++)
                {
                    priceForCurrentCocktail += command.Length * 1.0;
                    
                }

                if (priceForCurrentCocktail % 2 !=0)
                {
                    priceForCurrentCocktail *= 0.75;
                }

                currentProfit += priceForCurrentCocktail;


                if (currentProfit >= profitWanted)
                {
                    Console.WriteLine("Target acquired.");
                    Console.WriteLine($"Club income - {currentProfit:f2} leva.");
                    break;

                }

                command = Console.ReadLine();
            }

            if (command=="Party!")
            {
                double difference = Math.Abs(profitWanted - currentProfit);
                Console.WriteLine($"We need {difference:f2} leva more.");
                Console.WriteLine($"Club income - {currentProfit:f2} leva.");
            }

            
        }
    }
}
