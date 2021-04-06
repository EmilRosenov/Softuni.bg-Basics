using System;

namespace CinemaTickets
{
    class CinemaTickets
    {
        static void Main(string[] args)
        {
            int studentTicketCounter = 0;
            int standardTicketCounter = 0;
            int kidsTicketCounter = 0;
            int totalTicketsSold = 0;

            while (true)
            {
                string movieName = Console.ReadLine();

                if (movieName == "Finish")
                {
                    break;
                }

                int capacity = int.Parse(Console.ReadLine());
                string ticketType = Console.ReadLine();

                int numberOfTicketsPerMovie = 0;

                while (ticketType != "End")
                {

                    if (ticketType == "student")
                    {
                        studentTicketCounter++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTicketCounter++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidsTicketCounter++;
                    }

                    numberOfTicketsPerMovie++;
                    totalTicketsSold++;



                    if (numberOfTicketsPerMovie == capacity)
                    {
                        Console.WriteLine($"{movieName} - 100.00% full.");
                        break;
                    }


                    ticketType = Console.ReadLine();
                }

                if (ticketType == "End")
                {
                    Console.WriteLine($"{movieName} - {numberOfTicketsPerMovie * 100.0 / capacity:f2}% full.");

                }



            }
            double percentageStudentTickets = studentTicketCounter * 100.0 / totalTicketsSold;
            double percentageStandardTickets = standardTicketCounter * 100.0 / totalTicketsSold;
            double percentageKidTickets = kidsTicketCounter * 100.0 / totalTicketsSold;


            Console.WriteLine($"Total tickets: {totalTicketsSold}");
            Console.WriteLine($"{percentageStudentTickets:F2}% student tickets.");
            Console.WriteLine($"{percentageStandardTickets:F2}% standard tickets.");
            Console.WriteLine($"{percentageKidTickets:F2}% kids tickets.");

        }
    }
}
