using System;

namespace Exercise14_Triangle_NorthEast
{
    internal class Program
    {
        /// <summary>
        /// Write a program which asks for a width, and displays a triangle like this one:
        /// 
        /// Enter the desired width: 5
        /// 
        /// *****
        /// _****
        /// __***
        /// ___**
        /// ____*
        /// </summary>
        static void Main(string[] args)
        {
            int width, height;
            int row, column;
            int max;

            Console.Write("Enter the desired width: ");
            height = Convert.ToInt32(Console.ReadLine());
            width = 0;
            max = height;

            for (row = 0; row < height; row++)
            {
                for (column = 0; column < width; column++)
                    Console.Write(" ");

                for (int asterisks = 0; asterisks < max; asterisks++)
                    Console.Write("*");

                Console.WriteLine();
                width++;
                max--;
            }
        }
    }
}
