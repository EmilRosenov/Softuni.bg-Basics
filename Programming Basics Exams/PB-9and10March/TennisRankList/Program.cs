using System;

namespace TennisRankList
{
    class Program
    {
        static void Main(string[] args)
        {

            double numberTournamentsParticipating = double.Parse(Console.ReadLine());
            double startingPoints = double.Parse(Console.ReadLine());
            double pointsGained = 0;
            double winning = 0;

            for (int i = 0; i < numberTournamentsParticipating; i++)
            {
                string stageReached = Console.ReadLine();

                if (stageReached=="W")
                {
                    pointsGained += 2000;
                    winning++;
                }
                else if (stageReached == "F")
                {
                    pointsGained += 1200;
                }
                else if (stageReached == "SF")
                {
                    pointsGained += 720;
                }
                 
            }
            double totalPoints = pointsGained + startingPoints;
            
            //double pointsPerYear = Math.Abs(startingPoints - pointsGained);
            double averagePoints = pointsGained / numberTournamentsParticipating;
            //double averagePoints = pointsPerYear / numberTournamentsParticipating;
            double percentageWinning = winning / numberTournamentsParticipating * 100;

            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            Console.WriteLine($"{percentageWinning:f2}%");
        }
    }
}
