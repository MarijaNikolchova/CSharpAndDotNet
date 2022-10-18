using System;

namespace Exercise12_TwoNegatives
{
    internal class Program
    {
        /// <summary>
        /// Create a program to accept two numbers from the user and answer if both are negative or not.
        /// </summary>
        static void Main(string[] args)
        {
            int number1;
            int number2;

            Console.Write("number 1: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("number 2: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            if ((number1 < 0) && (number2 < 0))
                Console.WriteLine("the numbers are negative");

            if (!((number1 < 0) && (number2 < 0)))
                Console.WriteLine("the numbers are NOT negative");
        }
    }
}
