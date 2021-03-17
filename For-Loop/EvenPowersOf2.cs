using System;

namespace EvenPowersOf2
{
    class EvenPowersOf2
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int number = 2;

            for (int i = 0; i <= n; i += 2)
            {
                Console.WriteLine(Math.Pow(number, i));
            }
        }
    }
}
