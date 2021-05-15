using System;

namespace ChristmasTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberDays = int.Parse(Console.ReadLine());


           
            double totalSum = 0;
            
            
            int winningDays = 0;
            int losingDays = 0;

            for (int day = 1; day <= numberDays; day++)
            {
                string game = Console.ReadLine();
                double sumPerDay = 0;
                int numberWinsPerDay = 0;
                int numberLosesPerDay = 0;

                while (game !="Finish")
                {
                    
                    string result = Console.ReadLine();

                    

                    if (result=="win")
                    {
                        sumPerDay += 20;
                        numberWinsPerDay++;
                    }
                    else if (result == "lose")
                    {
                        numberLosesPerDay++;
                    }


                    game = Console.ReadLine();
                }

                if (numberWinsPerDay > numberLosesPerDay)
                {
                    sumPerDay = sumPerDay * 1.10;
                    totalSum += sumPerDay;
                    winningDays++;

                }
                else
                {
                    losingDays++;
                    totalSum += sumPerDay;
                }

            }

            if (winningDays > losingDays)
            {
                totalSum = totalSum * 1.20 ;
                Console.WriteLine($"You won the tournament! Total raised money: {totalSum:f2}");
                
            }
            else 
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalSum:f2}");
                
            }

        }
    }
}
