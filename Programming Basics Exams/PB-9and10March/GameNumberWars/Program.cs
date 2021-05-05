using System;

namespace GameNumberWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPlayer = Console.ReadLine();      
            string secondPlayer = Console.ReadLine();

            string command = Console.ReadLine();
            int firstPlayerPoints = 0;
            int secondPlayerPoints = 0;

            while (command !="End of game")
            {
                int firstPlayerCard = int.Parse(command);
                int secondPlayerCard = int.Parse(Console.ReadLine());

                if (firstPlayerCard > secondPlayerCard)
                {
                    firstPlayerPoints += firstPlayerCard - secondPlayerCard;
                }
                else if (secondPlayerCard > firstPlayerCard)
                {
                    secondPlayerPoints += secondPlayerCard - firstPlayerCard;
                }
                else
                {
                   int firstPlayerNumberWarsCard = int.Parse(Console.ReadLine());
                   int secondPlayerNumberWarsCard = int.Parse(Console.ReadLine());

                    //firstPlayerPoints = 0;
                    //secondPlayerPoints = 0;

                    if (firstPlayerNumberWarsCard> secondPlayerNumberWarsCard)
                    {
                        //firstPlayerPoints = firstPlayerNumberWarsCard - secondPlayerNumberWarsCard;
                        Console.WriteLine("Number wars!");
                        Console.WriteLine($"{firstPlayer} is winner with {firstPlayerPoints} points");
                        return;
                    }
                    else
                    {
                        //secondPlayerPoints = secondPlayerNumberWarsCard - firstPlayerNumberWarsCard;
                        Console.WriteLine("Number wars!");
                        Console.WriteLine($"{secondPlayer} is winner with {secondPlayerPoints} points");
                        return;
                    }

                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{firstPlayer} has {firstPlayerPoints} points");
            Console.WriteLine($"{secondPlayer} has {secondPlayerPoints} points");
        }
    }
}
