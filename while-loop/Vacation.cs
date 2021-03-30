using System;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());
            int days = 0;
            double totalMoney = 0;
            double daysSpending = 0;

            while (true)
            {
                string action = Console.ReadLine();
                double moneyForTheDay = double.Parse(Console.ReadLine());
                days++;

                if (action == "spend")
                {

                    daysSpending++;
                    currentMoney -= moneyForTheDay;
                    if (currentMoney < 0)
                    {
                        currentMoney = 0;
                    }
                    if (daysSpending == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{days}");
                        break;
                    }
                }
                if (action == "save")
                {

                    currentMoney += moneyForTheDay;
                    daysSpending = 0;

                }

                if (currentMoney >= moneyNeeded)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;
                }



                //Console.WriteLine(days);
                //double moneyForTheDay = double.Parse(Console.ReadLine());
            }
            //Ако 5 последователни дни Джеси само харчи, на конзолата да се изпише:
            //"You can't save the money."
            //"{Общ брой изминали дни}"
            //Ако Джеси събере парите за почивката на конзолата се изписва:
            //$"You saved the money for {общ брой изминали дни} days."
        }
    }
}
