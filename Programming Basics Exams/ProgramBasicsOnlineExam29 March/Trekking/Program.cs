using System;

namespace Trekking
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeForClimbingAMeter = double.Parse(Console.ReadLine());

            double georisTime = distanceInMeters * timeForClimbingAMeter;
            double slowingDownPer50m = 30;
            double slowingDown = Math.Floor(distanceInMeters / 50);
            double georisTimeWithSlowingDown = slowingDown * slowingDownPer50m;
            double georgisTotalTime = georisTime + georisTimeWithSlowingDown;

            double difference = georgisTotalTime- recordInSeconds;

            if (difference < 0)
            {
                Console.WriteLine($" Yes! The new record is {Math.Abs(georgisTotalTime):f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {difference:f2} seconds slower."); 
            }

        }
    }
}
