using System;

namespace Exercise10_EquivalentOperations
{
    internal class Program
    {
        /// <summary>
        /// Write a C# program to ask the user for three numbers (a, b, c) 
        /// and display the result of (a+b)·c and the result of a·c + b·c
        /// </summary>
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("Enter first number....");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number....");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number....");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Result of operation between {0}, {1} and {2}, (a+b)·c is {3} and a·b + a·c is {4}",
            num1, num2, num3, ((num1 + num2) * num3), (num1 * num3 + num2 * num3));
        }
    }
}
