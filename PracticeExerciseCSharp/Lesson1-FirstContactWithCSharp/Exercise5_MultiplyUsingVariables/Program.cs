using System;

namespace Exercise05_MultiplyUsingVariables
{
    internal class Program
    {
        /// <summary>
        /// Write a C# program to print the result of multiplying two numbers which will entered by the user.
        /// </summary>
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int multiplication;
            Console.WriteLine("Enter 1st number");
            number1 = System.Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            number2 = System.Convert.ToInt32(System.Console.ReadLine());
            multiplication = number1 * number2;
            Console.WriteLine("The multiplication is:");
            Console.WriteLine(multiplication);
        }
    }
}
