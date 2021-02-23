using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int confectioner = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakesMoney = cakes * 45;
            
            double wafflesMoney = waffles * 5.80;
            
            double pancakesMoney = pancakes * 3.20;
            
            
            double moneyForADay = (cakesMoney + wafflesMoney + pancakesMoney) * confectioner;
            
           
            double campaignMoney = moneyForADay * numberOfDays;
            
            double moneyAfterExpenses = campaignMoney - (campaignMoney / 8);
            
            Console.WriteLine(moneyAfterExpenses);

        }
    }
}
