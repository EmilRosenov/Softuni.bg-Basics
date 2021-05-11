using System;

namespace PcGameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double gamesSold = double.Parse(Console.ReadLine());
            double numberHearthstoneSold = 0;
            double numberForniteSold = 0;
            double numberOverwatchSold = 0;
            double otherGamesSold = 0;

            double allBooksSold = 0;
            //string gameName = " ";

            for (int i = 0; i < gamesSold; i++)
            {
                allBooksSold++;
                string gameName = Console.ReadLine();

                if (gameName == "Hearthstone")
                {
                    numberHearthstoneSold++;
                }

                else if (gameName == "Fornite")
                {
                    numberForniteSold++;
                }

                else if (gameName == "Overwatch")
                {
                    numberOverwatchSold++;    
                }

                else //if (gameName != "Hearthstone" && gameName != "Fornite" && gameName != "Overwatch")
                {     
                    otherGamesSold++;
                }

                
            }
            double percentageFornite = numberForniteSold / gamesSold * 100;
            double percentageOverwatch = numberOverwatchSold / gamesSold * 100;
            double percetageOthers = otherGamesSold / gamesSold * 100;
            double percentageHearthstone = numberHearthstoneSold / gamesSold * 100;

            Console.WriteLine($"Hearthstone - {percentageHearthstone:f2}%");
            Console.WriteLine($"Fornite - {percentageFornite:f2}%");
            Console.WriteLine($"Overwatch - {percentageOverwatch:f2}%");
            Console.WriteLine($"Others - {percetageOthers:f2}%");
        }
    }
}
