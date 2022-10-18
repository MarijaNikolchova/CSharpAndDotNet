using System;

namespace Exercise22_Rectangle
{
    internal class Program
    {
        /// <summary>
        /// Write a program which asks for a number, a width and a height and displays a rectangle of that width and that height, 
        /// using that number for the inner symbol, as in this example:
        /// 
        /// Enter a number: 4
        /// Enter the desired width: 3
        /// Enter the desired height: 5
        /// 
        /// 444
        /// 444
        /// 444
        /// 444
        /// 444
        /// </summary>
        static void Main(string[] args)
        {
            int n, width, height;
            int row, column;

            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the desired: ");
            width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the desired height: ");
            height = Convert.ToInt32(Console.ReadLine());

            for (row = 0; row < height; row++)
            {
                for (column = 0; column < width; column++)
                    Console.Write(n);

                Console.WriteLine();
            }
        }
    }
}
