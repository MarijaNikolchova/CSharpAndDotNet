using System;

namespace Exercise12_Formats
{
    internal class Program
    {
        /// <summary>
        /// Write a C# program to ask the user for a number and display ir four times in a row, 
        /// separated with blank spaces, and then four times in the next row, with no separation. 
        /// You must do it two times: first using Console.Write and then using {0}..
        /// </summary>
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a digit: ");
            n = Convert.ToInt32(Console.ReadLine());

            // Part A: "n n n n" using Write
            Console.Write(n);
            Console.Write(" ");
            Console.Write(n);
            Console.Write(" ");
            Console.Write(n);
            Console.Write(" ");
            Console.Write(n);
            Console.WriteLine();

            // Part B: "nnnn" using Write
            Console.Write(n);
            Console.Write(n);
            Console.Write(n);
            Console.WriteLine(n);
            Console.WriteLine();

            // Part C: "n n n n" using {0}
            Console.WriteLine("{0} {0} {0} {0}", n);

            // Part D: "nnnn" using {0}
            Console.WriteLine("{0}{0}{0}{0}", n); 
        }
    }
}
