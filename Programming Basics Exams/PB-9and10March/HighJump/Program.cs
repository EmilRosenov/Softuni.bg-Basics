using System;

namespace HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            int heightWantedCm = int.Parse(Console.ReadLine());

            int currentJumpCm = int.Parse(Console.ReadLine());

            int currentHeightCm = heightWantedCm - 30;

            int numberJumps = 1;
            int failedAttempts = 0;
            bool hasFailed = false;

            while (currentJumpCm <= heightWantedCm)
            {
                
                if (currentJumpCm > currentHeightCm)
                {

                    if (currentHeightCm > heightWantedCm)
                    {
                        break;
                    }
                    failedAttempts = 0;
                    
                    currentHeightCm += 5;
                }

                else if (currentJumpCm <= currentHeightCm)
                {
                   
                        failedAttempts++;

                        if (failedAttempts == 3)
                        {
                            //Console.WriteLine($"Tihomir failed at {currentHeightCm}cm after {numberJumps} jumps.");
                            hasFailed = true;
                            break;
                        }
                        //currentJumpCm = int.Parse(Console.ReadLine());
                        //numberJumps++;
                    
                }
                currentJumpCm = int.Parse(Console.ReadLine());
                numberJumps++;
            }

            if (hasFailed)
            {
                Console.WriteLine($"Tihomir failed at {currentHeightCm}cm after {numberJumps} jumps.");
            }
            else
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {heightWantedCm}cm after {numberJumps} jumps.");
            }
                
            
            
        }
    }
}
