using System;

namespace Exercise08_While_Counter
{
    internal class Program
    {
        /// <summary>
        /// Create a C# program to display the numbers 1 to 10 on screen, using "while".
        /// </summary>
        static void Main(string[] args)
        {
            int n = 1;

            while (n <= 10)
            {
                Console.Write("{0} ", n);
                n++;
            }
        }
    }
}
