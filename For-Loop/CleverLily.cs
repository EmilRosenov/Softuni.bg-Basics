using System;

namespace CleverLily
{
    class CleverLily
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double machinePrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());

            double savedMoney = 0;
            double toysCounter = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {

                    savedMoney += i * 5;
                    savedMoney--;
                }
                else
                {
                    toysCounter++;
                }


            }
            savedMoney += toysCounter * toysPrice;
            if (savedMoney >= machinePrice)
            {
                double diff = savedMoney - machinePrice;
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else
            {
                double diff = machinePrice - savedMoney;
                Console.WriteLine($"No! {diff:f2}");
            }
        }
    }
}
