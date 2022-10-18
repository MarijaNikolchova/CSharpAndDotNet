using System;

namespace Exercise13_FunctionFibonacci
{
    /// <summary>
    /// Create a program that uses recursion to calculate a number in the Fibonacci series 
    /// (in which the first two items are 1, and for the other elements, each one is the sum of the preceding two).
    /// </summary>
    internal class Program
    {
        public static int Fibonacci(int number)
        {
            if ((number == 1) || (number == 2))
                return 1;
            else
                return Fibonacci(number - 1) + Fibonacci(number - 2);
        }

        public static void Main()
        {
            int number;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci of {0} is {1}", number, Fibonacci(number));
        }
    }
}
