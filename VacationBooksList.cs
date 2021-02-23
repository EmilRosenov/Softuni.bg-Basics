using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            double pagesPerHr = double.Parse(Console.ReadLine());
            int numberOfDays = int.Parse(Console.ReadLine());

            
            double totalTimeForABook = numberOfPages / pagesPerHr;
            
            double hoursPerDay = totalTimeForABook / numberOfDays;
            Console.WriteLine(hoursPerDay);
        }
    }
}
