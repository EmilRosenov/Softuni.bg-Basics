using System;

namespace CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int starInterval = int.Parse(Console.ReadLine());
            int endInterval = int.Parse(Console.ReadLine());

            int sumSecondThird = 0;

            for (int first = starInterval; first <= endInterval; first++)
            {
                for (int second = starInterval; second <= endInterval; second++)
                {
                    for (int third = starInterval; third <= endInterval; third++)
                    {
                        
                        for (int fourth = starInterval; fourth <= endInterval; fourth++)
                        {
                            sumSecondThird = second + third;
                            if (first %2 != 0 && fourth % 2 == 0 && sumSecondThird % 2 == 0 && first > fourth)
                            {
                                Console.Write($"{first}{second}{third}{fourth} ");
                            }
                            
                            if (first % 2 == 0 && fourth % 2 != 0 && sumSecondThird % 2 == 0 && first > fourth)
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
