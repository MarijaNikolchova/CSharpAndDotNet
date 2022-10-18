using System;

namespace Exercise29_Statistics
{
    internal class Program
    {
        /// <summary>
        /// Write a program to compute several basic statistical operations: 
        /// it will accept numbers from the user and show their sum, average, 
        /// minimum and maximum, as in the following example:
        /// 
        /// Number? 5
        /// Total=5 Amount=1 Average=5 Maximum=5 Minimum=5
        /// Number? 2
        /// Total=7 Amount=2 Average=3 Maximum=5 Minimum=2
        /// Number? 0
        /// Bye!
        /// 
        /// (As seen in this example, the program will finish when the user enters 0).
        /// </summary>
        static void Main(string[] args)
        {
            int num;

            int total = 0, amount = 0;
            int maximum, minimum;

            Console.Write("number? ");
            num = Convert.ToInt32(Console.ReadLine());
            maximum = num;
            minimum = num;

            while (num != 0)
            {
                amount++;
                total += num;

                if (num > maximum)
                    maximum = num;

                if (num < minimum)
                    minimum = num;

                Console.WriteLine(
                    "Total={0} Amount={1} Average={2} maximum={3} minimum={4}",
                    total, amount, total / amount, maximum, minimum);

                Console.Write("number? ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Bye!");
        }
    }
}
