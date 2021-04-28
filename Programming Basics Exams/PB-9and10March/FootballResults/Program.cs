using System;
using System.Linq;

namespace FootballResults
{
    class Program
    {
        static void Main(string[] args)
        {
            int gamesPlayed = 3;

            int homeWins = 0;
            int awayWins = 0;
            int draws = 0;
            

            for (int i = 0; i < gamesPlayed; i++)
            {
                string result = Console.ReadLine();

                if (result[0] > result[2])
                {
                    homeWins++;
                }
                else if (result[0] < result[2])
                {
                    awayWins++;
                }
                else
                {
                    draws++;
                }
               
            }
            Console.WriteLine($"Team won {homeWins} games.");
            Console.WriteLine($"Team lost {awayWins} games.");
            Console.WriteLine($"Drawn games: {draws}");
        }
    }
}
