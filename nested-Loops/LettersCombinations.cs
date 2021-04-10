using System;

namespace LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char letterStartInterval = char.Parse(Console.ReadLine());
            char secondLetterEndInterval = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            int combinationsCounter = 0;

            for (char x1 = letterStartInterval; x1 <= secondLetterEndInterval; x1++)
            {
                for (char x2 = letterStartInterval; x2 <= secondLetterEndInterval; x2++)
                {
                        for (char x3 = letterStartInterval; x3 <= secondLetterEndInterval; x3++)
                        {
                            if (x1 != thirdLetter &&
                                x2 != thirdLetter &&
                                x3 != thirdLetter)

                            {
                                combinationsCounter++;
                                Console.Write($"{x1}{x2}{x3} ");
                            }
                        }
                }
                
            }
            Console.Write(combinationsCounter);

        }
    }
}
