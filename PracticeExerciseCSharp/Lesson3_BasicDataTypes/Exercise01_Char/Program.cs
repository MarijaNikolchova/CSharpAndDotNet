using System;

namespace Exercise01_Char
{
    internal class Program
    {
        /// <summary>
        /// Write a program to ask the user for three letters and display them in reverse order.
        /// </summary>
        static void Main(string[] args)
        {
            char letter, letter2, letter3;

            Console.Write("Enter letter: ");
            letter = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter letter: ");
            letter2 = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter letter: ");
            letter3 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}", letter3, letter2, letter);
        }
    }
}
