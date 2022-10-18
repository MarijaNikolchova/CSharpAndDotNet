using System;

namespace Exercise04_MultipleOperations
{
    internal class Program
    {
        /// <summary>
        /// Create a C# program to print the result of the following operations:
        /// 
        /// • -1 + 3 * 5
        /// • (24+5) % 7
        /// • 15 + -4*6 / 11
        /// • 2 + 10 / 6 * 1 - 7 % 2
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine(-1 + 3 * 5);
            Console.WriteLine((24 + 5) % 7);
            Console.WriteLine(15 + -4 * 6 / 11);
            Console.WriteLine(2 + 10 / 6 * 1 - 7 % 2);
        }
    }
}
