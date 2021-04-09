using System;

namespace UniquePinCodeColleague
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            for (int one = 1; one <= numberOne; one++)
            {
                for (int two = 2; two <= numberTwo; two++)
                {
                    for (int three = 1; three <= numberThree; three++)
                    {
                        if (three % 2 == 0 && one % 2 == 0)
                        {
                            if (two == 2)
                            {
                                Console.WriteLine($"{one} {two} {three} ");
                            }
                            if (two > 2 && two <= 7)
                            {
                                if (two % 2 == 1)
                                {
                                    Console.WriteLine($"{one} {two} {three} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
