using System;

namespace WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            char endSector = char.Parse(Console.ReadLine());
            int numberRowsFirstSector = int.Parse(Console.ReadLine());
            int numberOfSeatsOddRow = int.Parse(Console.ReadLine());

            int currentrow = 0;
            int counter = 0;

            for (char sector = 'A'; sector <= endSector; sector++, numberRowsFirstSector++)
            {
                for (int row = 1; row <= numberRowsFirstSector; row++)
                {
                    currentrow = row;

                    if (currentrow % 2 != 0)
                    {
                        for (char seats = 'a'; seats < 'a' + numberOfSeatsOddRow; seats++)
                        {
                            //currentSeats += 97 + seats;
                            Console.WriteLine($"{sector}{row}{seats}");
                            counter++;
                        }
                    }
                    else if (currentrow % 2 == 0)
                    {
                        for (char seats = 'a'; seats < 'a' + numberOfSeatsOddRow + 2; seats++)
                        {
                            //currentSeats += 97 + seats + currentrow;
                            Console.WriteLine($"{sector}{row}{seats}");
                            counter++;
                        }
                    }
                    //counter++;


                }
            }
            Console.WriteLine(counter);
        }
    }
}