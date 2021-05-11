using System;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string coffee = Console.ReadLine();
            string sugarLevel = Console.ReadLine();
            double numberDrinks = double.Parse(Console.ReadLine());

            double price = 0;
            double totalPrice = 0;

            if (coffee== "Espresso")
            {
                if (sugarLevel== "Without")
                {
                    price = 0.90;
                    price *= 0.65;
                    totalPrice = price * numberDrinks;
                }
                else if (sugarLevel == "Normal")
                {
                    price = 1.00;
                    totalPrice = price * numberDrinks;
                }
                else if (sugarLevel == "Extra")
                {
                    price = 1.20;
                    totalPrice = price * numberDrinks;
                }
            }
            else if (coffee == "Cappuccino")
            {
                if (sugarLevel == "Without")
                {
                    price = 1.00;
                    price *= 0.65;
                    totalPrice = price * numberDrinks;
                }
                else if (sugarLevel == "Normal")
                {
                    price = 1.20;
                    totalPrice = price * numberDrinks;
                }
                else if (sugarLevel == "Extra")
                {
                    price = 1.60;
                    totalPrice = price * numberDrinks;
                }
            }
            else if (coffee == "Tea")
            {
                if (sugarLevel == "Without")
                {
                    price = 0.50;
                    price *= 0.65;
                    totalPrice = price * numberDrinks;
                }
                else if (sugarLevel == "Normal")
                {
                    price = 0.6;
                    totalPrice = price * numberDrinks;
                }
                else if (sugarLevel == "Extra")
                {
                    price = 0.7;
                    totalPrice = price * numberDrinks;
                }

                
            }


            if (coffee=="Espresso" && numberDrinks>=5)
            {
                totalPrice *= 0.75;
            }

            

            if (totalPrice > 15)
            {
                totalPrice *= 0.80;
            }

            Console.WriteLine($"You bought {numberDrinks} cups of {coffee} for {totalPrice:f2} lv.");
        }
    }
}
