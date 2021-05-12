using System;

namespace careForPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodBoughtKG = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int foodLeftGrams = foodBoughtKG * 1000;

            while (command != "Adopted")
            {
        
                int gramsEatenPerMeal = int.Parse(command);

                foodLeftGrams -= gramsEatenPerMeal;


                command = Console.ReadLine();
            }
            if (foodLeftGrams >= 0)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodLeftGrams} grams.");
            }
            else
            {
                int difference = 0 - foodLeftGrams;
                Console.WriteLine($"Food is not enough. You need {Math.Abs(difference)} grams more.");
            }
        }
    }
}
