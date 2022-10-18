using System;

namespace Exercise17_Char_for
{
    internal class Program
    {
        /// <summary>
        /// Create a program to write the letters "B" to "N" (uppercase), using "for"
        /// </summary>
        static void Main(string[] args)
        {
            for (char i = 'B'; i <= 'N'; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
