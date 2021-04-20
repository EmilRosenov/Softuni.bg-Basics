using System;

namespace PrimePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginningFirstPair = int.Parse(Console.ReadLine());
            int beginningSecondPair = int.Parse(Console.ReadLine());
            int firstDifference = int.Parse(Console.ReadLine());
            int secondDifference = int.Parse(Console.ReadLine());
            

            for (int firstPair = beginningFirstPair; firstPair <= beginningFirstPair + firstDifference; firstPair++)
            {
                for (int secondPair = beginningSecondPair; secondPair <= beginningSecondPair + secondDifference; secondPair++)
                {
                    bool isFirstPairPrime = true;
                    bool isSecondPairPrime = true;

                    for (int i = 2; i <= Math.Sqrt(firstPair); i++)
                    {
                        if (firstPair % i == 0)
                        {
                            isFirstPairPrime = false;
                            break;
                        }
                    }
                    for (int j = 2; j <= Math.Sqrt(secondPair); j++)
                    {
                        if (secondPair % j == 0)
                        {
                            isSecondPairPrime = false;
                            break;
                        }
                        
                    }
                    if (isFirstPairPrime && isSecondPairPrime)
                    {
                        Console.WriteLine($"{firstPair}{secondPair}");
                        break;
                    }
                }
                
            }
            
        }
    }
}
