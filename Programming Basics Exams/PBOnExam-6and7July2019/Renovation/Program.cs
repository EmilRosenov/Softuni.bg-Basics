using System;

namespace Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            double heightWall = double.Parse(Console.ReadLine()); 
            double widthWall = double.Parse(Console.ReadLine());
            double percentageNotToBePainted = double.Parse(Console.ReadLine());
            double total = heightWall * widthWall*4;
            double totalPercentageToBePainted = Math.Ceiling(total - (total * percentageNotToBePainted)/100);
            double difference = 0;
            double totalLitresPAint = 0;

            bool isEnough = false;


            string command = Console.ReadLine();

            while (command != "Tired!")
            {
                double litresPaint = double.Parse(command);

                totalLitresPAint += litresPaint;

                if (totalLitresPAint > totalPercentageToBePainted)
                {
                    
                    isEnough = true;
                    difference = totalLitresPAint - totalPercentageToBePainted;
                    Console.WriteLine($"All walls are painted and you have {difference} l paint left!");
                    break;
                }
                if (totalLitresPAint == totalPercentageToBePainted)
                {
                    isEnough = true;
                    Console.WriteLine($"All walls are painted! Great job, Pesho!");
                    break;
                }


                difference = Math.Abs(totalLitresPAint - totalPercentageToBePainted);

                command = Console.ReadLine();
            }

            if (!isEnough)
            {
               
                Console.WriteLine($"{difference} quadratic m left.");
            }
        }
    }
}
