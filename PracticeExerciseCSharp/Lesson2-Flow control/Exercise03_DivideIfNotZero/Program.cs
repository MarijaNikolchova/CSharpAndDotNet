using System;

namespace Exercise03_DivideIfNotZero
{
    internal class Program
    {
        /// <summary>
        /// Write a C# program to ask the user for two numbers, 
        /// and show their division if the second number is not zero; 
        /// otherwise, it will display "I cannot divide
        /// </summary>
        static void Main(string[] args)
        {
            int number1, number2;

            Console.Write("Enter the first number:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number:");
            number2 = Convert.ToInt32(Console.ReadLine());

            if (number2 != 0)
            {
                Console.WriteLine("The result for {0} / {1} is {2}",
                number1, number2, number1 / number2);
            }

            if (number2 == 0)
                Console.WriteLine("No result");
        }
    }
}
