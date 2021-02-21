using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int depositLenght = int.Parse(Console.ReadLine());
            double annualInterest = double.Parse(Console.ReadLine());

            
            double currentInterest = (deposit * annualInterest) / 100;
            
            double monthlyInterest = currentInterest / 12;
            
            double finalsum = deposit + (depositLenght * monthlyInterest);
            Console.WriteLine(finalsum);
        }
    }
}
