using System;

namespace SecondProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value:");
            //int number = int.Parse(Console.ReadLine());
            int num;
            if (int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine($"Entered number {num}");
            }
            else
            {
                Console.WriteLine($"Wrong input");

            }

        }
    }
}
