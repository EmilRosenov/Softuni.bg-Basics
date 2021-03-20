using System;

namespace Odd_EvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0.00;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0.00;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;




            if (n == 0)
            {
                Console.WriteLine("OddSum=0.00,");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine("EvenSum=0.00,");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }


            else
            {
                for (int i = 1; i <= n; i++)
                {
                    double currentNumber = double.Parse(Console.ReadLine());
                    if (n == 1)
                    {
                        Console.WriteLine($"OddSum={currentNumber:f2},");
                        Console.WriteLine($"OddMin={currentNumber:f2},");
                        Console.WriteLine($"OddMax={currentNumber:f2},");
                        Console.WriteLine("EvenSum=0.00,");
                        Console.WriteLine("EvenMin=No,");
                        Console.WriteLine("EvenMax=No");
                    }
                    if (i % 2 == 1)
                    {
                        oddSum += currentNumber;
                    }

                    if (currentNumber > oddMax && i % 2 == 1)
                    {
                        oddMax = currentNumber;
                    }
                    if (currentNumber < oddMin && i % 2 == 1)
                    {
                        oddMin = currentNumber;
                    }

                    if (i % 2 == 0)

                    {
                        evenSum += currentNumber;

                    }
                    if (currentNumber > evenMax && i % 2 == 0)
                    {
                        evenMax = currentNumber;
                    }
                    if (currentNumber < evenMin && i % 2 == 0)

                    {
                        evenMin = currentNumber;
                    }
                }
            }
            if (n > 1)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }

        }
    }
}
