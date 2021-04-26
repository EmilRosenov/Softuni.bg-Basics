using System;

namespace MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string contractLenght = Console.ReadLine();
            string typeContract = Console.ReadLine();
            string internetAdded = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());

            double pricePM = 0;
            double PriceForTheContract = 0;
            double discount = 0;
            double total = 0;
            // "one"  "two" "Small",  "Middle", "Large"или "ExtraLarge"

            if (contractLenght =="one")
            {
                if (typeContract== "Small")
                {
                    pricePM = 9.98;
                }
                else if (typeContract == "Middle")
                {
                    pricePM = 18.99;
                }
                else if (typeContract == "Large")
                {
                    pricePM = 25.98;
                }
                else if (typeContract == "ExtraLarge")
                {
                    pricePM = 35.99;
                }

                
            }
            else if (contractLenght == "two")
            {
                if (typeContract == "Small")
                {
                    pricePM = 8.58;
                }
                else if (typeContract == "Middle")
                {
                    pricePM = 17.09;
                }
                else if (typeContract == "Large")
                {
                    pricePM = 23.59;
                }
                else if (typeContract == "ExtraLarge")
                {
                    pricePM = 31.79;
                }
            }


            if (internetAdded=="yes")
            {
                if (pricePM <= 10)
                {
                    pricePM += 5.50;
                }
                else if (pricePM > 10 && pricePM <=30)
                {
                    pricePM += 4.35;
                }
                else if (pricePM > 30)
                {
                    pricePM += 3.85;
                }
            }

            if (contractLenght == "one")
            {
                PriceForTheContract = pricePM * months;
                Console.WriteLine($"{PriceForTheContract:f2} lv.");
            }
            else
            {
                PriceForTheContract = pricePM * months;
                total = PriceForTheContract * 0.9625;

                Console.WriteLine($"{total:f2} lv.");
            }
           
        }
    }
}
