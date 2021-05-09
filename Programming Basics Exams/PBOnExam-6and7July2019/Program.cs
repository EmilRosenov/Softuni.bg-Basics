using System;

namespace PBOnExam_6and7July2019
{
    class Program
    {
        static void Main(string[] args)
        {
            double maxSum = 0;
            string strongestWord = " ";

            while (true)
            {
                string command = Console.ReadLine();
                double sum = 0;
                

                if (command!= "End of words")
                {
                    for (int i = 0 ; i < command.Length; i++)
                    {
                        sum += command[i];
                        
                    }

                    if (command[0] == 'a' || command[0] == 'e' || command[0] == 'i'
                            || command[0] == 'o' || command[0] == 'u' || command[0] == 'y'
                            || command[0] == 'A' || command[0] == 'E' || command[0] == 'I'
                            || command[0] == 'O' || command[0] == 'U' || command[0] == 'Y')
                    {
                        sum *= command.Length;
                    }
                    else
                    {
                        sum /= command.Length;
                        sum = Math.Floor(sum);
                    }

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        strongestWord = command;
                    }
                }
                if (command == "End of words")
                {
                   
                    Console.WriteLine($"The most powerful word is {strongestWord} - {maxSum}");
                    break;
                }
            }
        }
    }
}
