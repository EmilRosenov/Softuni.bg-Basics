using System;

namespace CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            double minutesPerDay = double.Parse(Console.ReadLine());
            double numberWalksPerDay = double.Parse(Console.ReadLine());
            double caloriesRecieved = double.Parse(Console.ReadLine());
            double caloriesPerMinute = 5;

            double totalMinutes = minutesPerDay * numberWalksPerDay;

            double caloriesBurnt = totalMinutes * caloriesPerMinute;

            if (caloriesRecieved * 0.5 <= caloriesBurnt)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesBurnt}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesBurnt}.");
            }
        }
    }
}
