using System;

namespace NameGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxPoints = 0;
            string bestPlayer = "";
            string name = Console.ReadLine();

            while (name != "Stop")
            {
                int points = 0;

                
                    for (int i = 0; i < name.Length; i++)
                    {
                        int numberWritten = int.Parse(Console.ReadLine());

                        if (numberWritten == name[i])
                        {
                            points += 10;
                        }
                        else
                        {
                            points += 2;
                        }

                        if (points >= maxPoints)
                        {
                            maxPoints = points;
                            bestPlayer = name;
                        }
                    }
                name = Console.ReadLine();
            }
            if (name == "Stop")
            {
                Console.WriteLine($"The winner is {bestPlayer} with {maxPoints} points!");
            }
        }
    }
}
