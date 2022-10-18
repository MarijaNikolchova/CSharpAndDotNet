using System;

namespace Exercise32_PrimeNumber
{
    internal class Program
    {
        /// <summary>
        /// Write a program which asks the user for an integer number and 
        /// answers if it is a prime number or not.
        /// </summary>
        static void Main(string[] args)
        {
            int number;
            int dividers = 0;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
                if (number % i == 0)
                    dividers++;

            if (dividers == 2)
                Console.WriteLine("The number is prime");
            else
                Console.WriteLine("The number is not prime");
        }
    }
}
