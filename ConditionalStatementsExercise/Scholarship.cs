using System;

namespace Scholarship
{
    class Scholarship
    {
        static void Main(string[] args)
        {
            double minIcome = double.Parse(Console.ReadLine());

            double averageGrade = double.Parse(Console.ReadLine());
            double minWage = double.Parse(Console.ReadLine());

            double SocialScholarship = Math.Floor(minWage * 0.35);
            double exellentScholarship = Math.Floor(averageGrade * 25);

            if (minIcome > minWage && averageGrade < 4.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (minWage > minIcome && averageGrade < 4.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

            else if (minWage < minIcome && averageGrade < 5.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

            else if (minWage > minIcome && averageGrade < 5.50)
            {
                Console.WriteLine($"You get a Social scholarship {SocialScholarship} BGN");
            }


            else if (minWage > minIcome && averageGrade >= 5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results { exellentScholarship} BGN");
            }

            else if (minWage < minIcome && averageGrade >= 5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results { exellentScholarship} BGN");
            }

            else if (SocialScholarship > exellentScholarship)
            {
                Console.WriteLine($"You get a Social scholarship{SocialScholarship} BGN");
            }

            else
            {
                Console.WriteLine($"You get a scholarship for excellent results { exellentScholarship} BGN");
            }
        }
    }
}
