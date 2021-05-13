using System;

namespace energyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            double order = double.Parse(Console.ReadLine());

            double price = 0;
            double discount = 0;
            double total = 0;

            //"Watermelon", "Mango", "Pineapple" или "Raspberry"

            //"small" или "big"

            if (fruit == "Watermelon")
            {
                if (size == "small")
                {
                    price = order * 2 * 56.00;
                }
                else if (size == "big")
                {
                    price = order * 5 * 28.70;
                }
            }
            else if (fruit == "Mango")
            {
                if (size == "small")
                {
                    price = order * 2 * 36.66;
                }
                else if (size == "big")
                {
                    price = order * 5 * 19.60;
                }
            }
            else if (fruit == "Pineapple")
            {
                if (size == "small")
                {
                    price = order * 2 * 42.10;
                }
                else if (size == "big")
                {
                    price = order * 5 * 24.80;
                }
            }
            else if (fruit == "Raspberry")
            {
                if (size == "small")
                {
                    price = order * 2 * 20;
                }
                else if (size == "big")
                {
                    price = order * 5 * 15.20;
                }
            }

            if (price >= 400 && price<=1000 )
            {
                discount = price * 0.15;
                total = price - discount;
                Console.WriteLine($"{total:f2} lv.");
            }
            else if (price > 1000)
            {
                discount = price * 0.5;
                total = price - discount;
                Console.WriteLine($"{total:f2} lv.");
            }
            else
            {
                Console.WriteLine($"{price:f2} lv.");
            }
        }
    }
}
