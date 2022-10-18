using System;

namespace Exercise06_UseOf_0_AndComments
{
    internal class Program
    {
        /// <summary>
        /// Write a C# program to ask the user for three numbers and display their multiplication.
        /// The first line must be a comment with your name and surname.It MUST look as follows:
        /// 
        /// Enter the first number to multiply
        /// 12
        /// Enter the second number to multiply
        /// 23
        /// Enter the third number to multiply
        /// 2
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            int number1, number2, number3;
            Console.Write("Enter the first number to multiply: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number to multiply: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number to multiply: ");
            number3 = Convert.ToInt32(Console.ReadLine());
            int result = number1 * number2 * number3;
            Console.WriteLine("Result: {0} x {1} x {2} = {3}", number1, number2, number3, result);
        }
    }

}
