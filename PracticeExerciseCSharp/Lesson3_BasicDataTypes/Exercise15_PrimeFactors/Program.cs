using System;

namespace Exercise15_PrimeFactors
{
    internal class Program
    {
        /// <summary>
        /// Create a program that displays a number (entered by the user) as a 
        /// product of its prime factors. For example, 60 = 2 · 2 · 3 · 5
        /// 
        /// (Hint: it can be easier if the solution is displayed as 60 = 2 · 2 · 3 · 5 · 1)
        /// </summary>
        static void Main(string[] args)
        {
            int n;
            int d = 2;

            Console.Write("Enter the number: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (n > 1)
            {
                while (n % d == 0)
                {
                    Console.Write(d);
                    Console.Write(" · ");
                    n = n / d;
                }

                d++;
            }
            Console.Write(1);
        }
    }
}
