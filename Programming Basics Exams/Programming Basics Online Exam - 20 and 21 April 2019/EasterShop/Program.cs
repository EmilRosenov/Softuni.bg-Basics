using System;

namespace EasterShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfEgssBeginning = int.Parse(Console.ReadLine());

            int currentNumber = amountOfEgssBeginning;
            int numberEggsSold = 0;

            string command = Console.ReadLine();

            while (command != "Close")
            {
                if (command == "Buy")
                {
                    int amountOfEggsToBeBought = int.Parse(Console.ReadLine());

                    
                    numberEggsSold += amountOfEggsToBeBought;

                    if (amountOfEggsToBeBought > currentNumber)
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {currentNumber}.");
                        break;
                    }
                    currentNumber -= amountOfEggsToBeBought;

                }
                else if (command == "Fill")
                {
                    int amountOfEggsToBeAdded = int.Parse(Console.ReadLine());

                    currentNumber += amountOfEggsToBeAdded;
                }


                

                command = Console.ReadLine();
            }
            if (command == "Close")
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{numberEggsSold} eggs sold.");

            }
        }
    }
}
