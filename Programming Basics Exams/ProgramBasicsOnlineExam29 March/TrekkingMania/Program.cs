using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfGroups = double.Parse(Console.ReadLine());
            double musalaGroup = 0;
            double montblanGroup = 0;
            double kilimandjaroGroup = 0;
            double k2Group = 0;
            double everestGroup = 0;
            double totalPeople = 0;

            for (double groups = 1; groups <= numberOfGroups; groups++)
            {
                double numberOfPeopleInAGroup = double.Parse(Console.ReadLine());
                totalPeople += numberOfPeopleInAGroup;

                if (numberOfPeopleInAGroup <= 5)
                {
                    musalaGroup += numberOfPeopleInAGroup;
                }
                else if (numberOfPeopleInAGroup > 5 && numberOfPeopleInAGroup <= 12)
                {
                    montblanGroup += numberOfPeopleInAGroup;
                }
                else if (numberOfPeopleInAGroup > 12 && numberOfPeopleInAGroup <= 25)
                {
                    kilimandjaroGroup += numberOfPeopleInAGroup;
                }
                else if (numberOfPeopleInAGroup > 25 && numberOfPeopleInAGroup <= 40)
                {
                    k2Group += numberOfPeopleInAGroup;
                }
                else if (numberOfPeopleInAGroup >= 40)
                {
                    everestGroup += numberOfPeopleInAGroup;
                }
            }

            double musalaPercentage = musalaGroup / totalPeople * 100;
            double montblanPercentage = montblanGroup / totalPeople * 100;
            double kilimandjaroPercentage = kilimandjaroGroup / totalPeople * 100;
            double k2Percentage = k2Group / totalPeople * 100;
            double everestPercentage = everestGroup / totalPeople * 100;

            Console.WriteLine($"{musalaPercentage:f2}%");
            Console.WriteLine($"{montblanPercentage:f2}%");
            Console.WriteLine($"{kilimandjaroPercentage:f2}%");
            Console.WriteLine($"{k2Percentage:f2}%");
            Console.WriteLine($"{everestPercentage:f2}%");

        }
    }
}
