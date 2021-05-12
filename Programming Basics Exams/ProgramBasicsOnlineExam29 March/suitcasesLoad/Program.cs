using System;

namespace suitcasesLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            double planeCapacity = double.Parse(Console.ReadLine());


            string command = Console.ReadLine();
            int numberOfSuitcases = 0;
            double suitcasesTotalLoad = 0;

            bool isTrue = true;

            while (command != "End")
            {

                double suitcaseLoad = double.Parse(command);
                

                if (suitcaseLoad > planeCapacity)
                {
                    isTrue = false;
                    Console.WriteLine("No more space!");
                    Console.WriteLine($"Statistic: {numberOfSuitcases} suitcases loaded.");
                    break;
                }

                
                if (numberOfSuitcases % 3 != 0)
                {
                    suitcasesTotalLoad += suitcaseLoad;
                }

                else if (numberOfSuitcases % 3 == 0)
                {
                    suitcasesTotalLoad += suitcaseLoad * 1.10;
                }

                if (suitcasesTotalLoad > planeCapacity)
                {
                    isTrue = false;
                    Console.WriteLine("No more space!");
                    Console.WriteLine($"Statistic: {numberOfSuitcases} suitcases loaded.");
                    break;
                }

                numberOfSuitcases++;
                command = Console.ReadLine();
            }

            if (isTrue)
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
                Console.WriteLine($"Statistic: {numberOfSuitcases} suitcases loaded.");
            }
        }
    }
}
