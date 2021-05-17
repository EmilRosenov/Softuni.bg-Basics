using System;

namespace EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int colouredEggs = int.Parse(Console.ReadLine());

            int redColouredEggs = 0;
            int orangeColouredEggs = 0;
            int blueColouredEggs = 0;
            int greenColouredEggs = 0;
            string bestColour = " ";

            for (int i = 1; i <= colouredEggs; i++)
            {
                string colour = Console.ReadLine();

                if (colour=="red")
                {
                    redColouredEggs++;
                }
                else if (colour== "orange")
                {
                    orangeColouredEggs++;
                }
                else if (colour == "blue")
                {
                    blueColouredEggs++;
                }
                else if (colour == "green")
                {
                    greenColouredEggs++;
                }
            }

            int max1 = Math.Max(redColouredEggs, orangeColouredEggs);
            int max2 = Math.Max(blueColouredEggs, greenColouredEggs);
            int maxNumberEggs = Math.Max(max1, max2);

            if (redColouredEggs > orangeColouredEggs 
                && redColouredEggs > blueColouredEggs 
                && redColouredEggs > greenColouredEggs)
            {
                bestColour = "red";
            }

            else if (orangeColouredEggs > redColouredEggs
                && orangeColouredEggs > blueColouredEggs
                && orangeColouredEggs > greenColouredEggs)
            {
                bestColour = "orange";
            }

            else if (blueColouredEggs > redColouredEggs
               && blueColouredEggs > orangeColouredEggs
               && blueColouredEggs > greenColouredEggs)
            {
                bestColour = "blue";
            }
            else if (greenColouredEggs > redColouredEggs
               && greenColouredEggs > orangeColouredEggs
               && greenColouredEggs > blueColouredEggs)
            {
                bestColour = "green";
            }


            Console.WriteLine($"Red eggs: {redColouredEggs}");
            Console.WriteLine($"Orange eggs: {orangeColouredEggs}");
            Console.WriteLine($"Blue eggs: {blueColouredEggs}");
            Console.WriteLine($"Green eggs: {greenColouredEggs}");
            Console.WriteLine($"Max eggs: {maxNumberEggs} -> {bestColour}");
        }
    }
}
