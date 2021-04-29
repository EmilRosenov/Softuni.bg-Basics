using System;

namespace Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int controllMinutes = int.Parse(Console.ReadLine());
            int controllSec = int.Parse(Console.ReadLine());
            double lengthInM = double.Parse(Console.ReadLine());
            double secToCover100M = double.Parse(Console.ReadLine());

            double totalTimeControll = controllMinutes * 60 + controllSec;
            double slowDownAmount = lengthInM / 120;
            double totalSlowDown = slowDownAmount * 2.5;
            double totalTime = (lengthInM / 100) * secToCover100M - totalSlowDown;

           

            if (totalTime <= totalTimeControll)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {totalTime:f3}.");
            }
            else
            {
                double difference = Math.Abs(totalTimeControll - totalTime);
                Console.WriteLine($"No, Marin failed! He was {difference:f3} second slower.");
            }


        }
    }
}
