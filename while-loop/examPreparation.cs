using System;

namespace ExamPreparation2
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfUnacceptableGrades = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            //if "Enough"
            //⦁	"Average score: {средна оценка}"
            //⦁	"Number of problems: {броя на всички задачи}"
            //⦁	"Last problem: {lastproblemName}"

            //if counter = numberOfUnacceptableGrades;
            //"You need a break, {count} poor grades."

            int unacceptableGradeCounter = 0;
            int acceptableGradeCounter = 0;
            int totalGradeCounter = 0;
            int gradeSum = 0;
            double avgGrade = 0;

            string lastProblem = string.Empty;

            while (input != "Enough")
            {

                int gradeEntered = int.Parse(Console.ReadLine());
                if (gradeEntered <= 4)

                {
                    unacceptableGradeCounter++;
                }
                else if (gradeEntered > 4)
                {
                    acceptableGradeCounter++;
                }
                totalGradeCounter = unacceptableGradeCounter + acceptableGradeCounter;

                if (unacceptableGradeCounter == numberOfUnacceptableGrades)
                {
                    Console.WriteLine($"You need a break, {numberOfUnacceptableGrades} poor grades.");
                    break;
                }

                gradeSum += gradeEntered;
                avgGrade = gradeSum * 1.0 / totalGradeCounter;
                lastProblem = input;
                input = Console.ReadLine();
            }
            if (input == "Enough")
            {

                Console.WriteLine($"Average score: {avgGrade:f2}");
                Console.WriteLine($"Number of problems: {totalGradeCounter}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }

        }
    }
}

