using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtInCentimeters = int.Parse(Console.ReadLine());
            int widthtInCentimeters = int.Parse(Console.ReadLine());
            int heghtInCentimeters = int.Parse(Console.ReadLine());
            double percentageOthers = double.Parse(Console.ReadLine());



            
            double volume = lenghtInCentimeters * widthtInCentimeters * heghtInCentimeters;

            double totalVolumeInLitres = volume * 0.001;
            
            double filledPercentage = percentageOthers * 0.01;

            Console.WriteLine(totalVolumeInLitres * (1 - filledPercentage));

        }
    }
}
