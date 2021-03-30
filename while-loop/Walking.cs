using System;
using System.Security.Cryptography;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string command = Console.ReadLine();
            int sumStepsOut = 0;
           
            while (command != "Going home")
            {
                int stepsWhenOut = int.Parse(command);
                sumStepsOut += stepsWhenOut;
                if (sumStepsOut >= 10000)
                {
                    int difference = sumStepsOut - 10000;
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{difference} steps over the goal!");
                    break;

                }

                command = Console.ReadLine();
            }
            if (sumStepsOut < 10000)
            {
                int additionalSteps = int.Parse(Console.ReadLine());
                sumStepsOut += additionalSteps;

                if (sumStepsOut >= 10000)
                {
                    int difference = sumStepsOut - 10000;
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{difference} steps over the goal!");
                }
                else
                {
                    int stepsToRachTheGoal = 10000 - sumStepsOut;
                    Console.WriteLine($"{stepsToRachTheGoal} more steps to reach goal.");
                }
            }

        }
    }
}
