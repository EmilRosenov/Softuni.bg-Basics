using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryNumber = int.Parse(Console.ReadLine());

            int presentationsCounter = 0;
            double finalAssesment = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Finish")
                {
                    break;

                }

                presentationsCounter++;

                double averageGrade = 0;

                for (int i = 0; i < juryNumber; i++)
                {
                    double gradeGiven = double.Parse(Console.ReadLine());
                    averageGrade += gradeGiven;

                }
                averageGrade /= juryNumber;
                finalAssesment += averageGrade;

                Console.WriteLine($"{input} - {averageGrade:f2}");
                
            }
            finalAssesment /= presentationsCounter;
            Console.WriteLine($"Student's final assessment is {finalAssesment:f2}");
        }
    }
}
