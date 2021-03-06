using System;

namespace WorldSwimmingRecord
{
    class WorldSwimmingRecord
    {
        static void Main(string[] args)
        {
            double Wr = double.Parse(Console.ReadLine());
            double distanceInM = double.Parse(Console.ReadLine());
            double timeInSecForM = double.Parse(Console.ReadLine());

            
            double timeNeeded = distanceInM * timeInSecForM;
            double timeAdded = Math.Floor(distanceInM / 15);
            double timeAddedTotal = timeAdded * 12.50;
            double totalTime = timeNeeded + timeAddedTotal;


            
            if (Wr <= totalTime)
            {

                Console.WriteLine($"No, he failed! He was {Math.Abs(Wr - totalTime):f2} seconds slower.");
            }


            else if (totalTime < Wr)
            {

                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }

        }
    }
}
