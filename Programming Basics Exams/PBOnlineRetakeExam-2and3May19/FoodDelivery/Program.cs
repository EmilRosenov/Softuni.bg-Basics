using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberChickenMenus = double.Parse(Console.ReadLine());  
            double numberFishMenus = double.Parse(Console.ReadLine());  
            double numberVegiMenus = double.Parse(Console.ReadLine());

            double chickenMenu = 10.35;
            double fishMenu = 12.40;
            double vegiMenu = 8.15;

            double totalChicken = numberChickenMenus * chickenMenu;
            double totalFish = numberFishMenus * fishMenu;
            double totalVegi = numberVegiMenus * vegiMenu;

            double totalPriceNodelivery = totalChicken + totalFish + totalVegi;
            double dessert = totalPriceNodelivery * 0.2;
            double delivery = 2.50;

            double total = totalPriceNodelivery + dessert + delivery;

            Console.WriteLine($"Total: {total:f2}");

        }
    }
}
