using System;

namespace Exercise10_OddNumbers_Descending
{
    internal class Program
    {
        /// <summary>
        /// Create a program to display on the screen the odd 
        /// numbers from 15 to 7 (downwards), using "while
        /// </summary>
        static void Main(string[] args)
        {
            int n = 15;

            while (n >= 7)
            {
                Console.WriteLine(n);
                n -= 2;
            }
        }
    }
}
