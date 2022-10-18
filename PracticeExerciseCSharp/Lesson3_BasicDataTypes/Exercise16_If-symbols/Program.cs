using System;

namespace Exercise16_If_symbols
{
    internal class Program
    {
        /// <summary>
        /// Create a program to ask the user for a symbol and answer if is an uppercase vowel, 
        /// a lowercase vowel, a digit or any other symbol, using "if".
        /// </summary>
        static void Main(string[] args)
        {
            char symbol;

            Console.Write("insert anything: ");
            symbol = Convert.ToChar(Console.ReadLine());

            if (symbol >= '0' && symbol <= '9')
                Console.WriteLine("it's a number");

            else if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i')
                    || (symbol == 'o') || (symbol == 'u'))
                Console.WriteLine("it's a lowercase vowel");

            else if ((symbol == 'A') || (symbol == 'E') || (symbol == 'I')
                    || (symbol == 'O') || (symbol == 'U'))
                Console.WriteLine("it's a upercase vowel");

            else
                Console.WriteLine("it's a symbol");
        }
    }
}
