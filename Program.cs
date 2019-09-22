using System;

namespace Dreamland
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            int width = int.Parse(Console.ReadLine());
            for (int b = width; b > 0; b--)
            {
                for (int a = width - b; a<width; a++)
                {
                    Console.Write(" ");
                }
                for (int a = 0; a < width - b; a++)
                {
                    Console.Write("*");
                }
                for (int a = 0; a < width - b; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int b = width-1; b > 0; b--)
            {
                Console.Write(" ");
                Console.Write("*");
            }
            Console.ReadKey();
        }
    }
}
