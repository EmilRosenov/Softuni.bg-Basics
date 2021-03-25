using System;

namespace MinNumber
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Stop")
                {
                    Console.WriteLine(minNumber);
                    break;
                }

                int number = int.Parse(input);

                if (number < minNumber)
                {
                    minNumber = number;
                }
            }
        }
    }
}
