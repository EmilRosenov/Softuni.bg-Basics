using System;

namespace EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberClients = int.Parse(Console.ReadLine());


            double basketPrice = 1.50;
            double wreathPrice = 3.80;
            double chockoladBunnyPrice = 7.00;
            double totalMoney = 0;
            double priceAfterDiscount = 0;

            for (int i = 1; i < numberClients; i++)
            {
                string command = Console.ReadLine();
                int numberItems = 0;
                double itemsPricePerClient = 0;
                double price = 0;

                while (command != "Finish")
                {
                    string purchase = Console.ReadLine();
                    numberItems++;

                    if (purchase== "basket")
                    {
                        price += basketPrice;
                    }
                    else if (purchase == "wreath")
                    {
                        price += wreathPrice;
                    }
                    else if (purchase =="chocolate bunny")
                    {
                        price += chockoladBunnyPrice;
                    }


                    itemsPricePerClient += price;


                    command = Console.ReadLine();
                }

                if (numberItems % 2==0)
                {
                    priceAfterDiscount = itemsPricePerClient * 0.8;
                    Console.WriteLine($"You purchased {numberItems} items for {priceAfterDiscount} leva.");

                }
                else
                {
                    priceAfterDiscount = itemsPricePerClient;
                    Console.WriteLine($"You purchased {numberItems} items for {priceAfterDiscount} leva.");
                }

                totalMoney += priceAfterDiscount;
            }

            double averageSpentPP = totalMoney / numberClients;
            Console.WriteLine($"Average bill per client is: {averageSpentPP} leva.");
        }
    }
}
