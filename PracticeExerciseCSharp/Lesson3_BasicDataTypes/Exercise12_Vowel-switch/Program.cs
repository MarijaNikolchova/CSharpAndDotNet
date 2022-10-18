using System;

namespace Exercise12_Vowel_switch
{
    internal class Program
    {
        /// <summary>
        /// Create a program to ask the user for a symbol and answer if it is a 
        /// (lowercase)vowel, a digit, or any other symbol, using "switch".
        /// </summary>
        static void Main(string[] args)
        {
            char symbol;

            Console.Write("Enter a symbol: ");
            symbol = Convert.ToChar(Console.ReadLine());

            switch (symbol)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("It's a lowercase vowel.");
                    break;
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    Console.WriteLine("It's a digit.");
                    break;
                default:
                    Console.Write("It's another symbol.");
                    break;
            }
        }
    }
}
