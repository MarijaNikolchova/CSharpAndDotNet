using System;

namespace Exercise11_SumNumbers
{
    internal class Program
    {
        /// <summary>
        /// Write a C# program to ask the user for an undetermined amount of numbers (until 0 is entered) and display their sum, as follows:
        ///
        /// Number? 5
        /// Total = 5
        /// Number? 10
        /// Total = 15
        /// Number? -2
        /// Total = 13
        /// Number? 0
        /// Finished
        /// </summary>
        static void Main(string[] args)
        {
            int number;
            int sum = 0;

            do
            {
                Console.Write("Number: ");
                number = Convert.ToInt32(Console.ReadLine());

                sum = number + sum;

                if (number != 0)
                    Console.WriteLine("Total: {0}", sum);
            }
            while (number != 0);

            Console.WriteLine("Finished");
        }
    }
}
