using System;

namespace fitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            //"Gym" "Boxing" "Yoga" "Zumba" "Dances" "Pilates"

            double price = 0;
            double discount = 0;
            double difference = 0;


            if (sport== "Gym")
            {
                if (sex=="m")
                {
                    price = 42;
                }
                else if (sex=="f")
                {
                    price = 35;
                }
            }
            else if (sport == "Boxing")
            {
                if (sex == "m")
                {
                    price = 41;
                }
                else if (sex == "f")
                {
                    price = 37;
                }
            }
            else if (sport == "Yoga")
            {
                if (sex == "m")
                {
                    price = 45;
                }
                else if (sex == "f")
                {
                    price = 42;
                }
            }
            else if (sport == "Zumba")
            {
                if (sex == "m")
                {
                    price = 34;
                }
                else if (sex == "f")
                {
                    price = 31;
                }
            }
            else if (sport == "Dances")
            {
                if (sex == "m")
                {
                    price = 51;
                }
                else if (sex == "f")
                {
                    price = 53;
                }
            }
            else if (sport == "Pilates")
            {
                if (sex == "m")
                {
                    price = 39;
                }
                else if (sex == "f")
                {
                    price = 37;
                }
            }

            if (age <= 19)
            {
                discount = price * 0.2;
                price = price - discount;

                if (balance >= price)
                {
                    Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                }
                else
                {
                    difference = price - balance;
                    Console.WriteLine($"You don't have enough money! You need ${difference:f2} more.");
                }
            }
            else
            {
                if (balance >= price)
                {
                    Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                }
                else
                {
                    difference = price - balance;
                    Console.WriteLine($"You don't have enough money! You need ${difference:f2} more.");
                }
            }

        }
    }
}
