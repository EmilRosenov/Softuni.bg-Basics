using System;

namespace HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double maxNumber = double.MinValue;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;



                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            double sumNomaxNr = sum - maxNumber;
            if (maxNumber == sumNomaxNr)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }
            else
            {

                double diff = Math.Abs(maxNumber - sumNomaxNr);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }

        }
    }
}
