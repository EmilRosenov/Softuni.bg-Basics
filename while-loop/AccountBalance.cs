using System;

namespace AccountBalance
{
    class AccountBalance
    {
        static void Main(string[] args)
        {
            double sumDeposit = 0;


            while (true)
            {

                string input = Console.ReadLine();
                if (input == "NoMoreMoney")
                {
                    break;
                }

                double number = double.Parse(input);

                if (number < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                sumDeposit += number;
                Console.WriteLine($"Increase: {number:f2}");

            }

            Console.WriteLine($"Total: {sumDeposit:f2}");

        }
    }
}
