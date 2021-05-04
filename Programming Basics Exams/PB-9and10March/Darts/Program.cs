using System;

namespace Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingPoints = 301;
            int numberOfSuccessfullShots = 0;
            int numberOfUnsuccessfullShots = 0;

            string playersName = Console.ReadLine();

            string command = " ";

            while ((command = Console.ReadLine()) != "Retire") 
            {
                
                int points = int.Parse(Console.ReadLine());

                if (command == "Single")
                {
                   
                    if (points > startingPoints)
                    {
                        numberOfUnsuccessfullShots++;
                        continue;
                    }
                    else
                    {
                        startingPoints -= points;
                    }
                }
                else if (command == "Double")
                {
                    points = points * 2;

                    if (points > startingPoints)
                    {
                        numberOfUnsuccessfullShots++;
                        continue;
                    }
                    else
                    {
                        startingPoints -= points;
                    }
                }
                else if (command == "Triple")
                {
                    points = points * 3;

                    if (points > startingPoints)
                    {
                        numberOfUnsuccessfullShots++;
                        continue;
                    }
                    else
                    {
                        startingPoints -= points;
                    }
                    
                }

                numberOfSuccessfullShots++;

                if (startingPoints == 0)
                {
                    Console.WriteLine($"{playersName} won the leg with {numberOfSuccessfullShots} shots.");
                    return;
                }

                
                
                

                //command = Console.ReadLine();
            }
            Console.WriteLine($"{playersName} retired after {numberOfUnsuccessfullShots} unsuccessful shots."); 
        }
    }
}
