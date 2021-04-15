using System;

namespace safePasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxCountGenPass = int.Parse(Console.ReadLine());

            bool isReached = false;
            int counter = 0;
            int A = 35;
            int B = 64;
            
                    for (int x = 1; x <= a; x++)
                    {
                        for (int y = 1; y <= b; y++)
                        {

                            if (A > 55)
                            {
                                A = 35;
                            }
                            if (B > 96)
                            {
                                B = 64;
                            }

                            Console.Write($"{(char)A}{(char)B}{x}{y}{(char)B}{(char)A}|");
                            counter++;

                            A++;
                            B++;

                            if (counter == maxCountGenPass)
                            {
                                isReached = true;
                                break;
                            }
                        }
                         if (isReached)
                         {
                             break;
                         }
                    }                  
        }
    }
}
