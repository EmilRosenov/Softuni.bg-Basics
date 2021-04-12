using System;

namespace ChallengeTheWeddingParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int numberOfTables = int.Parse(Console.ReadLine());

            
            for (int numberMen = 1; numberMen <= men; numberMen++)
            {
                
                if (numberOfTables == 0)
                {
                    break;
                }


                for (int numberWomen = 1; numberWomen <= women; numberWomen++)
                {

                    numberOfTables -= 1;
                    Console.Write($"({numberMen} <-> {numberWomen}) ");
                    if (numberOfTables == 0)
                    {
                        break;
                    }
                }
            }
        }
    }
}
