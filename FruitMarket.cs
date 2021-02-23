using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());
           
            double amountBananasKg = double.Parse(Console.ReadLine());
            
            double amountOrangesKg = double.Parse(Console.ReadLine());
            
            double amountRaspberriesKg = double.Parse(Console.ReadLine());
            
            double amountStrawberriesKg = double.Parse(Console.ReadLine());
            
            double raspberriesPrice = strawberriesPrice / 2;
            
            double orangesPrice = raspberriesPrice - (raspberriesPrice * 0.4);
            
            double bananasPrice = raspberriesPrice - (raspberriesPrice * 0.8);
            
            double bananaSum = bananasPrice * amountBananasKg;
            double orangeSum = amountOrangesKg * orangesPrice;
            double raspberrySum = raspberriesPrice * amountRaspberriesKg;
            double strawberrySum = strawberriesPrice * amountStrawberriesKg;
            double totalSum = bananaSum + orangeSum + raspberrySum + strawberrySum;

            Console.WriteLine(Math.Round(totalSum, 2));
        }
    }
}
