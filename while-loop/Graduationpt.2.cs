using System;

namespace Graduationpt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            int failedCounter = 0;
            double totalRating = 0;

            //graduation
            //excluded

            while (grade <= 12)
            {
                double rating = double.Parse(Console.ReadLine());

                if (rating >= 4)
                {
                    totalRating += rating;
                    grade++;
                }
                else
                {
                    failedCounter++;

                    if (failedCounter == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        break;
                    }
                }

            }
            double average = totalRating / 12;
            if (grade == 13)
            {
                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            }

        }
    }
}
