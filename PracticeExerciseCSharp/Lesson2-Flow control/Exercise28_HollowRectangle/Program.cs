using System;

namespace Exercise28_HollowRectangle
{
    internal class Program
    {
        /// <summary>
        /// Write a program which asks for a symbol, a width and a height and displays a 
        /// hollow rectangle of that width and that height, using that number for the outer symbol, 
        /// as in this example:
        /// 
        /// Enter a symbol: 4
        /// 
        /// Enter the desired width: 3
        /// Enter the desired height: 5
        /// 
        /// 444
        /// 4 4
        /// 4 4
        /// 4 4
        /// 444
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            int row, column;

            Console.Write("Enter a symbol: ");
            int symbol = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the desired width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the desired height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (row = 1; row <= height; row++)
            {
                for (column = 1; column <= width; column++)
                {
                    if ((row == 1) || (row == height))
                        Console.Write(symbol);
                    else
                    {
                        if ((column == 1) || (column == width))
                            Console.Write(symbol);
                        else
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
