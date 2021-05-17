using System;

namespace EasterBakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = 0;

            double flourPrice = double.Parse(Console.ReadLine());
            double kgsFlour = double.Parse(Console.ReadLine());
            double kgsSugar = double.Parse(Console.ReadLine());
            int numberDozensEggs = int.Parse(Console.ReadLine());
            int numberPacksYeast = int.Parse(Console.ReadLine());

            double totalMoneyForFlour = flourPrice * kgsFlour;
            double sugarPrice = flourPrice * 0.75;
            double totalMoneyForSugar = sugarPrice * kgsSugar;
            double totalMoneyForEggs = flourPrice *1.10 * numberDozensEggs;
            double totalMoneyForYeast = numberPacksYeast * (sugarPrice*0.2);

            moneyNeeded = totalMoneyForFlour + totalMoneyForSugar + totalMoneyForEggs + totalMoneyForYeast;

            Console.WriteLine($"{moneyNeeded:f2}");
        }
    }
}
