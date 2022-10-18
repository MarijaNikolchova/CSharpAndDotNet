using System;

namespace Exercise06_RepeatUntil0
{
    internal class Program
    {
        /// <summary>
        /// Create a C# program to ask the user for a number "x" and display 10*x. 
        /// It must repeat until the user enters 0 (using "while").
        /// </summary>
        static void Main(string[] args)
        {
            int number;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            while (number != 0)
            {
                Console.WriteLine(number * 10);

                Console.Write("Enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
