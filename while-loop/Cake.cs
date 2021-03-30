using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {

            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int totalPiecesOfCake = width * lenght;
            int sumPieces = 0;



            while (true)
            {

                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    int difference = totalPiecesOfCake - sumPieces;
                    Console.WriteLine($"{difference} pieces are left.");
                    break;
                }

                int numberOfPieces = int.Parse(input);
                sumPieces += numberOfPieces;


                if (sumPieces > totalPiecesOfCake)
                {
                    int differencce = sumPieces - totalPiecesOfCake;
                    Console.WriteLine($"No more cake left! You need {Math.Abs(differencce)} pieces more.");
                    break;
                }


            }

        }
    }
}
