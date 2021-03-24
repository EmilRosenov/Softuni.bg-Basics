using System;

namespace while_loop
{
    class ReadText
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string text = Console.ReadLine();

                if (text == "Stop")
                {
                    break;
                }
                Console.WriteLine(text);

            }
        }
    }
}
