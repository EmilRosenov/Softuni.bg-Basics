using System;

namespace DivideWithoutRemainder
{
    class DivideWithoutRemainder
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;


            for (int number = 1; number <= n; number++)
            {
                int enteredNumber = int.Parse(Console.ReadLine());

                if (enteredNumber % 2 == 0)
                {
                    group1++;
                }
                if (enteredNumber % 3 == 0)
                {
                    group2++;
                }
                if (enteredNumber % 4 == 0)
                {
                    group3++;
                }
            }
            double percent1 = group1 * 1.0 / n * 100;
            double percent2 = group2 * 1.0 / n * 100;
            double percent3 = group3 * 1.0 / n * 100;

            Console.WriteLine($"{percent1:f2}%");
            Console.WriteLine($"{percent2:f2}%");
            Console.WriteLine($"{percent3:f2}%");
        }
    }
}
