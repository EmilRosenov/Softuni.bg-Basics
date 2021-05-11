using System;

namespace TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            string pack = Console.ReadLine();
            string discount = Console.ReadLine();
            double daysNumber = double.Parse(Console.ReadLine());

            double price = 0;
            double totalPrice = 0;

            if (daysNumber == 0)
            {
                Console.WriteLine("Days must be positive number!");
                return;
            }

            if (daysNumber > 7)
            {
                daysNumber -= 1;
            }

            if (city != "Bansko" && city != "Borovets" && city != "Varna" && city != "Burgas")
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            else if (pack != "noEquipment" && pack != "withEquipment" 
                    && pack != "noBreakfast" && pack != "withBreakfast")
            {
                Console.WriteLine("Invalid input!");
                return;
            }


            if (city == "Varna" || city=="Burgas")
            {
                if (pack== "withBreakfast")
                {
                    price = 130;

                    if (discount == "yes")
                    {
                        price *= 0.88;
                    }

                }
                else if (pack == "noBreakfast")
                {
                    price = 100;

                    if (discount == "yes")
                    {
                        price *= 0.88;
                    }

                }
                
            }
            else if (city == "Bansko" || city == "Borovets")
            {
                if (pack == "withEquipment")
                {
                    price = 100;

                    if (discount == "yes")
                    {
                        price *= 0.90;
                    }
                }
                else if (pack == "noEquipment")
                {
                    price = 80;

                    if (discount == "yes")
                    {
                        price *= 0.95;
                    }
                }

            }

            totalPrice = daysNumber * price;

            Console.WriteLine($"The price is {totalPrice:f2}lv! Have a nice time!");    
        }
    }
}
