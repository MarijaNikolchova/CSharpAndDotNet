using System;

namespace Exercise08_CalculateValuesOfAFunction
{
    internal class Program
    {
        /// <summary>
        /// Create a program to display certain values of the function y = x2 - 2x + 1 
        /// (using integer numbers for x, ranging from -10 to +10)
        /// </summary>
        static void Main(string[] args)
        {
            int y, x;

            Console.WriteLine("y = x² - 2x +1");
            Console.WriteLine();

            for (x = -10; x <= 10; x++)
            {
                y = x * x - 2 * x + 1;
                Console.WriteLine(
                    "x = {0} ; y=({0})² - 2*({0}) +1 = {1}",
                    x, y);
            }
        }
    }
}
