using System;

namespace SecretDoorsLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxHundreds = int.Parse(Console.ReadLine());
            int maxTens = int.Parse(Console.ReadLine());
            int maxSingles = int.Parse(Console.ReadLine());

            int factor = 0;

            for (int x1 = 1; x1 <= maxHundreds; x1++)
            {
                if (x1 % 2 == 0)
                {
                    for (int x2 = 1; x2 <= maxTens; x2++)
                    {

                        for (int x3 = 1; x3 <= maxSingles; x3++)
                        {
                            if (x3 % 2 == 0 &&
                                x1 % 2 == 0 &&
                                x2 == 2)

                            {

                                Console.Write($"{x1} {x2} {x3}");
                                Console.WriteLine();
                            }
                            if (x2 > 2 && x2 <= 7 &&
                                x3 % 2 == 0)
                            {
                                if (x2 % 2 == 1)
                                {
                                    Console.Write($"{x1} {x2} {x3}");
                                    Console.WriteLine();
                                }
                            }

                        }
                    }
                
                }
            }
            
        }
    }
}
