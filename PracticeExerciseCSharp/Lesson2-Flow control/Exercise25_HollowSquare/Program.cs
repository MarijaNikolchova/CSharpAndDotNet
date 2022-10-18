using System;

namespace Exercise25_HollowSquare
{

    internal class Program
    {
        /// <summary>
        /// Write a program which asks for a symbol, a width and displays a hollow square 
        /// of that width, using that number for the outer symbol, as in this example:
        /// 
        /// Enter a symbol: 4
        /// Enter the desired width: 3
        /// 
        /// 444
        /// 4 4
        /// 444
        /// </summary>
        static void Main(string[] args)
        {
            int n, width;
            int i, j;

            Console.Write("Enter number for the border of the square: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter total: ");
            width = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < width; i++)
                Console.Write(n);

            Console.WriteLine();

            for (i = 0; i < (width - 2); i++)
            {
                Console.Write(n);

                for (j = 0; j < (width - 2); j++)
                    Console.Write(" ");

                Console.WriteLine(n);
            }

            for (i = 0; i < width; i++)
                Console.Write(n);

            Console.WriteLine();
        }
    }
}
