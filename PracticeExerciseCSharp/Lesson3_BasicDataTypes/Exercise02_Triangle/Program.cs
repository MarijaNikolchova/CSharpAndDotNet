using System;

namespace Exercise02_Triangle
{
    internal class Program
    {
        /// <summary>
        /// Write a program which asks for a symbol and a width, and displays a triangle of that width, 
        /// using that number for the inner symbol, as in this example:
        /// 
        /// Enter a symbol: 4
        /// Enter the desired width: 5
        /// 
        /// 44444
        /// 4444
        /// 444
        /// 44
        /// 4
        /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the desired width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            int height = width;
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write(n);
                }

                Console.WriteLine();
                width--;
            }
        }
    }
}
