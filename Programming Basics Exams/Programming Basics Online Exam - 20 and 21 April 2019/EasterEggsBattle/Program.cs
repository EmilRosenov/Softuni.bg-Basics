using System;

namespace EasterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfEggsPlayerOne = int.Parse(Console.ReadLine());
            int numberOfEggsPlayerTwo = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command!= "End of battle")
            {

               

                if (command =="one" )
                {
                    numberOfEggsPlayerTwo--;
                }
                else if(command=="two")
                {
                    numberOfEggsPlayerOne--;
                }

                if (numberOfEggsPlayerOne == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {numberOfEggsPlayerTwo} eggs left.");
                    break;
                }
                else if (numberOfEggsPlayerTwo == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {numberOfEggsPlayerOne} eggs left.");
                    break;
                }


                command = Console.ReadLine();
            }
            if (command == "End of battle")
            {
                Console.WriteLine($"Player one has {numberOfEggsPlayerOne} eggs left.");
                Console.WriteLine($"Player two has {numberOfEggsPlayerTwo} eggs left.");
                
            }
        }
    }
}
