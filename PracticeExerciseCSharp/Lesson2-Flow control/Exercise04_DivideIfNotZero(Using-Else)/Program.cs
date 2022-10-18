using System;

namespace Exercise04_DivideIfNotZero_Using_Else_
{
    internal class Program
    {
        /// <summary>
        /// Create a version of the previous program, using "else"
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
            else
                Console.WriteLine("No result");
        }
    }
}
