using System;

namespace Exercise20_HexadecimalAndBinary
{
    internal class Program
    {
        /// <summary>
        /// Create a program to ask the user for a number an display it both in hexadecimal and binary. 
        /// It must repeat until the user enters 0
        /// </summary>
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Enter a number:");
                n = Convert.ToInt32(Console.ReadLine());

                if (n != 0)
                {
                    Console.Write("Hexadecimal: ");
                    Console.WriteLine(Convert.ToString(n, 16));
                    Console.Write("Binary: ");
                    Console.WriteLine(Convert.ToString(n, 2));
                }
            }
            while (n != 0);
        }
    }
}
