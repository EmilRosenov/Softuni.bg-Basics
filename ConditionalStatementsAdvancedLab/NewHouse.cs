using System;

namespace NewHouse
{
    class NewHouse
    {
        static void Main(string[] args)
        {
            string flowertype = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            //"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"

            double totalPrice = 0;
            if (flowertype == "Roses")
            {
                totalPrice = numberOfFlowers * 5;
                if (numberOfFlowers > 80)
                {
                    totalPrice *= 0.9;
                }
            }
            else if (flowertype == "Dahlias")
            {
                totalPrice = numberOfFlowers * 3.8;
                if (numberOfFlowers > 90)
                {

                    if (numberOfFlowers > 90)

                    {
                        totalPrice *= 0.85;
                    }
                    //15% discount
                }
            }
            else if (flowertype == "Tulips")
            {
                totalPrice = numberOfFlowers * 2.8;
                if (numberOfFlowers > 80)

                {
                    totalPrice *= 0.85;
                }
                //15% discount
            }
            else if (flowertype == "Narcissus")
            {
                totalPrice = numberOfFlowers * 3;
                if (numberOfFlowers < 120)
                {
                    totalPrice *= 1.15;
                    //increase price with 15%
                }

            }
            else if (flowertype == "Gladiolus")
            {
                totalPrice = numberOfFlowers * 2.50;
                if (numberOfFlowers < 80)

                {
                    totalPrice *= 1.20;
                    //increase price with 20%
                }
            }

            double moneyLeft = budget - totalPrice;
            string output = string.Empty;
            if (budget >= totalPrice)
            {
                output = $"Hey, you have a great garden with {numberOfFlowers} {flowertype} and {moneyLeft:f2} leva left.";
            }
            else
            {
                output = $"Not enough money, you need {Math.Abs(moneyLeft):f2} leva more.";

            }
            Console.WriteLine(output);
        }
    }
}
