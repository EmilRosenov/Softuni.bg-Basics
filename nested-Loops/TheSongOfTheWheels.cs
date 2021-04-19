using System;

namespace TheSongOfTheWheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int sumAB = 0;
            int sumCD = 0;
            int sumABCD = 0;
            int sequence = 0;
            int i = 0;
            int j = 0;
            int k = 0;
            int l = 0;

            bool toWrite = false;
            bool isfound = false;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            sumAB = a * b;
                            sumCD = c * d;
                            sumABCD = sumAB + sumCD;


                            
                            if (a < b && c > d && sumABCD == M)
                            {
                                    sequence++;
                                    Console.Write($"{a}{b}{c}{d} ");
                                    toWrite = true;
                                    
                               
                                if (sequence == 4)
                                {
                                    i = a;
                                    j = b;
                                    k = c;
                                    l = d;
                                    isfound = true;
                                    
                                    
                                    
                                }
                            }
                            
                        }
                        
                    }
                    
                }
                
            }
            if (toWrite)
            {
                Console.WriteLine();
            }
            if (!isfound)
            {
                Console.WriteLine($"No!");
            }
            else if(isfound)
            {
                Console.WriteLine($"Password: {i}{j}{k}{l}");
            }
        }
    }
}
