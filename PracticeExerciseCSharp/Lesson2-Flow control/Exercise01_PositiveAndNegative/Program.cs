using System;

namespace Exercise01_PositiveAndNegative
{
    internal class Program
    {
        /// <summary>
        /// Write a C# program to get a number from the and answer whether it is positive or negative..
        /// </summary>
        static void Main(string[] args)
        {
            int a;
            Console.Write("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("is positive");

            if (a < 0)
                Console.WriteLine("is negative");
        }
    }
}
