﻿using System;

namespace SumOfTwoNrs
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNr = int.Parse(Console.ReadLine());

            int combinationCounter = 0;
            bool isFound = false;

            for (int i = start; i <= end; i++)
            {
                
                for (int j = start; j <= end; j++)
                {

                    combinationCounter++;
                    if (i + j == magicNr)
                    {
                        Console.WriteLine($"Combination N:{combinationCounter} ({i} + {j} = {magicNr})");
                        isFound = true;
                        break;
                           
                    }

                   
                }
               
                if (isFound)
                {
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"{combinationCounter} combinations - neither equals {magicNr }");
               
            }
        }
    }
}
