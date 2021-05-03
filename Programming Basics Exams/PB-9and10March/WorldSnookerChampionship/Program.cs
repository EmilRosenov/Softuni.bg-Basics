using System;

namespace WorldSnookerChampionship
{
    class Program
    {
        static void Main(string[] args)
        {
            string stage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            double numberTickets = double.Parse(Console.ReadLine());
            string trophyPhoto = Console.ReadLine();

            double price = 0;

            //Quarter final,Semi final,Final
            //Standard, Premium, VIP

            if (stage == "Quarter final")
            {
                if (ticketType == "Standard")
                {
                    price = numberTickets * 55.50;
                }
                else if (ticketType == "Premium")
                {
                    price = numberTickets * 105.20;
                }
                else if (ticketType == "VIP")
                {
                    price = numberTickets * 118.90;
                }
            }
            else if (stage == "Semi final")
            {
                if (ticketType == "Standard")
                {
                    price = numberTickets * 75.88;
                }
                else if (ticketType == "Premium")
                {
                    price = numberTickets * 125.22;
                }
                else if (ticketType == "VIP")
                {
                    price = numberTickets * 300.40;
                }
            }
            else if (stage == "Final")
            {
                if (ticketType == "Standard")
                {
                    price = numberTickets * 110.10;
                }
                else if (ticketType == "Premium")
                {
                    price = numberTickets * 160.66;
                }
                else if (ticketType == "VIP")
                {
                    price = numberTickets * 400;
                }
            }

            if (trophyPhoto == "Y")
            {
                if (price <= 2500)
                {
                    double priceForPhotos = numberTickets * 40;
                    price += priceForPhotos;
                }
                
                else if (price > 2500 && price <= 4000)
                {
                    double discount = price * 0.10;
                    price = price - discount;

                    double priceForPhotos = numberTickets * 40;
                    price += priceForPhotos;
                }
                else if (price > 4000)
                {
                    double discount = price * 0.25;
                    price = price - discount;
                }
            }
            else if(trophyPhoto=="N")
            {
                if (price > 4000)
                {
                    double discount = price * 0.25;
                    price = price - discount;
                }
                else if (price > 2500 && price <= 4000)
                {
                    double discount = price * 0.10;
                    price = price - discount;
                }
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
