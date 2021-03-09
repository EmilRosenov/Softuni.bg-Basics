using System;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int numberOfRows = int.Parse(Console.ReadLine());
            int numberOfColumns = int.Parse(Console.ReadLine());
            double totalIncome = 0;


            if (projectionType == "Premiere")
            {
                double income = numberOfRows * numberOfColumns;
                totalIncome = income * 12.00;
            }
            else if (projectionType == "Normal")
            {
                double income = numberOfRows * numberOfColumns;
                totalIncome = income * 7.50;
            }
            else if (projectionType == "Discount")
            {
                double income = numberOfRows * numberOfColumns;
                totalIncome = income * 5.00;
            }
            Console.WriteLine($"{totalIncome:f2}");

        }
    }
}
