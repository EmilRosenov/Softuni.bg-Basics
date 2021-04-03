using System;

namespace Combinations
{
    class Combinations
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int x1 = 0; x1 <= n; x1++)
            {
                int x2 = 0;
                while (x2 <= n)
                {
                    for (int x3 = 0; x3 <= 25; x3++)
                    {
                        int combinations = x1 + x2 + x3;

                        if (combinations == n)
                        {
                            counter++;
                        }
                    }
                    x2++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
