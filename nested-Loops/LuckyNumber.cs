using System;

namespace LuckyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int sumLeft = 0;
            int sumRight = 0;

            for (int first = 1; first <= 9; first++)
            {
                for (int second = 1; second <= 9; second++)
                {
                    for (int third = 1; third <= 9; third++)
                    {
                        for (int fourth = 1; fourth <= 9; fourth++)
                        {
                            sumLeft = first + second;
                            sumRight = third + fourth;

                            if (sumRight ==sumLeft &&
                                N % sumLeft == 0 &&
                                N % sumRight == 0)
                            {
                                Console.Write($"{first}{second}{third}{fourth} ");
                            }
                            
                        }
                    }
                }
            }
        }
    }
}
