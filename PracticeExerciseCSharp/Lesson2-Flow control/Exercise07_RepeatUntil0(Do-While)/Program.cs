using System;

namespace Exercise07_RepeatUntil0_Do_While_
{
    internal class Program
    {
        /// <summary>
        /// Create a C# program to ask the user for a number "x" and display 10*x. 
        /// It must repeat until the user enters 0 (using "do-while").
        /// </summary>
        static void Main(string[] args)
        {
            int number;

            do
            {
                Console.Write("Enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(number * 10);
            }
            while (number != 0);
        }
    }
}
