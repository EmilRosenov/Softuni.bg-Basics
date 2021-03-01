using System;

namespace AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            double surface = 0;

            if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                surface = side * side;

            }

            else if (figureType == "rectangle")
            {

                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                surface = side * height;

            }

            else if (figureType == "circle")
            {

                double radius = double.Parse(Console.ReadLine());
                surface = (radius * radius) * Math.PI;
            }
            else if (figureType == "triangle")
            {

                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                surface = (side * height) / 2;

            }
            Console.WriteLine($"{surface:F3}");
        }
    }
}
