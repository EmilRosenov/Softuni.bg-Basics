using System;

namespace EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int numberNights = int.Parse(Console.ReadLine());

            double price = 0;

            if (destination=="France")
            {
                if (dates== "21-23")
                {
                    price = numberNights * 30;
                }
                else if (dates=="24-27")
                {
                    price = numberNights * 35;
                }
                else if(dates=="28-31")
                {
                    price = numberNights * 40;
                }
            }
            else if (destination == "Italy")
            {
                if (dates == "21-23")
                {
                    price = numberNights * 28;
                }
                else if (dates == "24-27")
                {
                    price = numberNights * 32;
                }
                else if (dates == "28-31")
                {
                    price = numberNights * 39;
                }
            }
            else if (destination == "Germany")
            {
                if (dates == "21-23")
                {
                    price = numberNights * 32;
                }
                else if (dates == "24-27")
                {
                    price = numberNights * 37;
                }
                else if (dates == "28-31")
                {
                    price = numberNights * 43;
                }
            }

            Console.WriteLine($"Easter trip to {destination} : {price:f2} leva.");
        }
    }
}
