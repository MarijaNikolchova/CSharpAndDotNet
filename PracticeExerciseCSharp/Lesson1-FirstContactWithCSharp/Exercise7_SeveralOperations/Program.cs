using System;

namespace Exercise07_SeveralOperations
{
    internal class Program
    {
        /// <summary>
        /// Write a C# program to print on screen the result of adding, subtracting, multiplying and dividing two numbers typed by the user. 
        /// The remainder of the division must be displayed, too.
        /// 
        /// It might look like this:
        /// Enter a number: 12
        /// Enter another number: 3
        /// 12 + 3 = 15
        /// 12 - 3 = 9
        /// 12 x 3 = 36
        /// 12 / 3 = 4
        /// 12 mod 3 = 0
        /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);
            Console.WriteLine("{0} - {1} = {2}", number1, number2, number1 - number2);
            Console.WriteLine("{0} x {1} = {2}", number1, number2, number1 * number2);
            Console.WriteLine("{0} / {1} = {2}", number1, number2, number1 / number2);
            Console.WriteLine("{0} mod {1} = {2}", number1, number2, number1 % number2);
        }
    }

}
