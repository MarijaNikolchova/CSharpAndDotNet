using System;

namespace Exercise35_Exceptions
{
    internal class Program
    {
        /// <summary>
        /// reate a program to ask the user for two numbers and display their division. 
        /// Errors must be trapped using "try..catch".
        /// </summary>
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int division;

            Console.Write("Enter a number to divide: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number to divide: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                division = number1 / number2;

                Console.WriteLine("{0} / {1} = {2}", number1, number2, division);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by Zero");
                return;
            }
        }
    }
}
