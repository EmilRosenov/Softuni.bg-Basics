using System;

namespace Travelling
{
    class Travelling
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            //double minimumBudget = double.Parse(Console.ReadLine());


            while (destination != "End")
            {
                if (destination == "End")
                {
                    break;
                }


                double minimumBudget = double.Parse(Console.ReadLine());
                double sum = 0;
                while (sum < minimumBudget)
                {

                    double savedMoney = double.Parse(Console.ReadLine());
                    sum += savedMoney;

                    if (sum >= minimumBudget)
                    {
                        sum = 0;
                        Console.WriteLine($"Going to {destination}!");

                        break;
                    }
                }
                destination = Console.ReadLine();

            }
        }
    }
}
