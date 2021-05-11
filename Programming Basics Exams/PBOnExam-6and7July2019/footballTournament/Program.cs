using System;

namespace footballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string footballClub = Console.ReadLine();
            double numberGamesPlayed = double.Parse(Console.ReadLine());

            double numberWins=0;
            double numberDraws=0;
            double numberLosses=0;

            double points = 0;

            if (numberGamesPlayed == 0)
            {
                Console.WriteLine($"{footballClub} hasn't played any games during this season.");
            }

            else
            {
                for (int i = 1; i <= numberGamesPlayed; i++)
                {
                    char result = char.Parse(Console.ReadLine());

                    if (result == 'W')
                    {
                        numberWins++;
                        points += 3;
                    }
                    else if (result == 'D')
                    {
                        numberDraws++;
                        points += 1;
                    }
                    else if (result == 'L')
                    {
                        numberLosses++;
                    }
                }

                Console.WriteLine($"{footballClub} has won {points} points during this season.");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {numberWins}");
                Console.WriteLine($"## D: {numberDraws}");
                Console.WriteLine($"## L: {numberLosses}");

                double winRate = numberWins / numberGamesPlayed * 100;

                Console.WriteLine($"Win rate: {winRate:f2}%");
            }
        }
    }
}
