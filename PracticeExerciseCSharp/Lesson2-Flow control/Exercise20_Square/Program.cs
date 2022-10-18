using System;

namespace Exercise20_Square
{
    internal class Program
    {
        /// <summary>
        /// Write a program which asks for a number and a width, and displays a square of that width, using that number for the inner symbol, as in this example:
        /// 
        /// Enter a number: 4
        /// Enter the desired width: 3
        /// 
        /// 444
        /// 444
        /// 444
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            int n, width;     // User entered data
            int row, column;   // For loops

            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the desired: ");
            width = Convert.ToInt32(Console.ReadLine());

            for (row = 0; row < width; row++)
            {
                for (column = 0; column < width; column++)
                    Console.Write(n);

                Console.WriteLine();
            }
        }
    }
}
