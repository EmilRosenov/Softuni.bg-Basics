using System;

namespace DivisionWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double dividedby2group = 0;
            double dividedby3group = 0;
            double dividedby4group = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    dividedby2group++;
                }
                if (number % 3 == 0)
                {
                    dividedby3group++;
                }
                if (number % 4 == 0)
                {
                    dividedby4group++;
                }

            }

            double percentageDiv2 = dividedby2group / n * 100;
            double percentageDiv3 = dividedby3group / n * 100;
            double percentageDiv4 = dividedby4group / n * 100;

            Console.WriteLine($"{percentageDiv2:f2}%");
            Console.WriteLine($"{percentageDiv3:f2}%");
            Console.WriteLine($"{percentageDiv4:f2}%");

        }
    }
}
