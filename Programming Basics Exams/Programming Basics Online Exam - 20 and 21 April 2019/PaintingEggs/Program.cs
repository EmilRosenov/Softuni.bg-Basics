using System;

namespace PaintingEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string eggsSize = Console.ReadLine();
            string colour = Console.ReadLine();
            double orders = double.Parse(Console.ReadLine());

            double price = 0;
            


            if (eggsSize == "Large")
            {
                if (colour == "Red")
                {
                    price = orders * 16;
                }
                else if (colour == "Green")
                {
                    price = orders * 12;
                }
                else if (colour == "Yellow")
                {
                    price = orders * 9;
                }
            }
            else if (eggsSize == "Medium")
            {
                if (colour == "Red")
                {
                    price = orders * 13;
                }
                else if (colour == "Green")
                {
                    price = orders * 9;
                }
                else if (colour == "Yellow")
                {
                    price = orders * 7;
                }
            }
            else if (eggsSize == "Small")
            {
                if (colour == "Red")
                {
                    price = orders * 9;
                }
                else if (colour == "Green")
                {
                    price = orders * 8;
                }
                else if (colour == "Yellow")
                {
                    price = orders * 5;
                }
            }

            double profit = price * 0.65;

            
            Console.WriteLine($"{profit:f2} leva.");
        }
    }
}
