using System;

namespace VetParking
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberDays = double.Parse(Console.ReadLine());


            double numberOfHoursPerDay = double.Parse(Console.ReadLine());
            double totalTax = 0;
            
            


            for (int day= 1; day <= numberDays; day++)
            {
                double taxPerDay = 0;
                double tax = 0;

                for (int hour = 1; hour <= numberOfHoursPerDay; hour++)
                {
                    if (day % 2 != 0 && hour % 2 == 0)
                    {
                        tax += 1.25;
                    }
                    else if (day % 2 == 0 && hour % 2 != 0)
                    {
                        tax += 2.50;
                    }
                    else
                    {
                        tax += 1;
                    }
                    
                }
                taxPerDay = tax;
                totalTax += taxPerDay;
                Console.WriteLine($"Day: {day} - {taxPerDay:f2} leva");
            }

            Console.WriteLine($"Total: {totalTax:f2} leva");
        }
    }
}
