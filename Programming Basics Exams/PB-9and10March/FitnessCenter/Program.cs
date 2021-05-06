using System;

namespace FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberPeople = double.Parse(Console.ReadLine());

            //("Back", "Chest", "Legs", "Abs","Protein shake" or "Protein bar")

            double peopleTrainingBack = 0;
            double peopleTrainingChest = 0;
            double peopleTrainingLegs = 0;
            double peopleTrainingAbs = 0;
            double peopleBuyingShake = 0;
            double peopleBuyingBar = 0;

            double numberPplTraining = 0;
            double numberPplProtein = 0;


            for (int i = 0; i < numberPeople; i++)
            {
                string activity = Console.ReadLine();

                if (activity== "Back")
                {
                    peopleTrainingBack++;
                    numberPplTraining++;
                }
                else if (activity == "Chest")
                {
                    peopleTrainingChest++;
                    numberPplTraining++;
                }
                else if (activity == "Legs")
                {
                    peopleTrainingLegs++;
                    numberPplTraining++;
                }
                else if (activity == "Abs")
                {
                    peopleTrainingAbs++;
                    numberPplTraining++;
                }
                else if (activity == "Protein shake")
                {
                    peopleBuyingShake++;
                    numberPplProtein++;
                }
                else if (activity == "Protein bar")
                {
                    peopleBuyingBar++;
                    numberPplProtein++;
                }
            }


            double percentageWO = numberPplTraining / numberPeople * 100;
            double percentageProtein = numberPplProtein / numberPeople * 100;
            Console.WriteLine($"{peopleTrainingBack} - back");
            Console.WriteLine($"{peopleTrainingChest} - chest");
            Console.WriteLine($"{peopleTrainingLegs} - legs");
            Console.WriteLine($"{peopleTrainingAbs} - abs");
            Console.WriteLine($"{peopleBuyingShake} - protein shake");
            Console.WriteLine($"{peopleBuyingBar} - protein bar");
            Console.WriteLine($"{percentageWO:f2}% - work out");
            Console.WriteLine($"{percentageProtein:f2}% - protein");
        }
    }
}
