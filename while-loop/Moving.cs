using System;

namespace Moving
{
    class Moving
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            //3 calculate the free space
            int freespace = width * height * lenght;
            //2 create while loop for the moving of boxes
            string input = Console.ReadLine();

            while (input != "Done")
            {
                //2.1 remove the taken space from the free space
                freespace -= int.Parse(input);
                //2.2 check if there is no more free space left (freespace < 0) and break the loop

                if (freespace < 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(freespace)} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine();
            }

            if (input == "Done") //or: if (freespace >=0)
            {

                Console.WriteLine($"{freespace} Cubic meters left.");
            }
        }
    }
}
