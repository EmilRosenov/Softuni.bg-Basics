using System;

namespace foodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberDays = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());

            double totalEatenBiscuits = 0;
            double percentageEatenFood = 0;
            double dogsPercentageEatenFood = 0;
            double catsPercentageEatenFood = 0;
            double allAmountOfFoodEaten = 0;

            double dogsSum = 0;
            double catsSum = 0;
            

            for (int currentDay = 1; currentDay <= numberDays; currentDay++)
            {
                double foodEatenByDog = double.Parse(Console.ReadLine());
                double foodEatenByCat = double.Parse(Console.ReadLine());

                double sumPerDay = 0;

                sumPerDay = foodEatenByDog + foodEatenByCat;
                allAmountOfFoodEaten += sumPerDay;
                food -= sumPerDay;
                dogsSum += foodEatenByDog;
                catsSum += foodEatenByCat;

                if (currentDay % 3 == 0)
                {
                    totalEatenBiscuits += sumPerDay * 0.1;
                }

            }

            percentageEatenFood = allAmountOfFoodEaten / (allAmountOfFoodEaten+food) *100;

            dogsPercentageEatenFood = dogsSum/ allAmountOfFoodEaten *100;
            catsPercentageEatenFood = catsSum/ allAmountOfFoodEaten *100;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(totalEatenBiscuits)}gr.");
            Console.WriteLine($"{Math.Abs(percentageEatenFood):f2}% of the food has been eaten.");
            Console.WriteLine($"{dogsPercentageEatenFood:f2}% eaten from the dog.");
            Console.WriteLine($"{catsPercentageEatenFood:f2}% eaten from the cat.");
        }
    }
}
