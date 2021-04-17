using System;

namespace HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCounter = int.Parse(Console.ReadLine());
            int hoursPerDay = int.Parse(Console.ReadLine());

            int numberOfDays = 0;
            double currentPricePH = 0;
            double pricePH = 0;
            double totalPrice = 0;

            for (int days = 1; days <= daysCounter; days++)
            {
                numberOfDays++;
                currentPricePH = 0;

                for (int hours = 1; hours <= hoursPerDay; hours++)
                {
                   
                    if (days % 2 == 0 &&
                        hours % 2 != 0)
                    {
                        pricePH = 2.50;
                        currentPricePH += pricePH;
                        totalPrice += pricePH;
                    }
                    else if (days % 2 != 0 &&
                        hours % 2 == 0)
                    {
                        pricePH = 1.25;
                        currentPricePH += pricePH;
                        totalPrice += pricePH;
                    }
                    else
                    {
                        pricePH = 1.00;
                        currentPricePH += pricePH;
                        totalPrice += pricePH;
                    }
                    
                }
                Console.WriteLine($"Day: {numberOfDays} - {currentPricePH:f2} leva");
            }
            Console.WriteLine($"Total: {totalPrice:f2} leva");
        }
    }
}
