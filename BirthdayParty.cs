using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
        
            double hallRent = double.Parse(Console.ReadLine());
            double cakePrice = (hallRent * 20) / 100;
            
            double drinksPrice = cakePrice - (cakePrice * 45) / 100;

            double animator = hallRent / 3;

            Console.WriteLine(hallRent + cakePrice + drinksPrice + animator);
        }
    }
}
