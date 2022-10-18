using System;

namespace Exercise31_CalculatorParamsOfMain
{
    /// <summary>
    /// Create a program to calculate a sum, subtraction, product or division, analyzing the command line parameters:
    /// 
    /// calc 5 + 379
    /// 
    /// (Parameters must be a number, a sign, and another number; allowed signs are + - )
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {

            char operation = Convert.ToChar(args[1]);

            int number1 = Convert.ToInt32(args[0]);
            int number2 = Convert.ToInt32(args[2]);

            int result = 0;
            if (args.Length != 3)
            {
                switch (operation)
                {
                    case '+':
                        result = number1 + number2;
                        break;
                    case '-':
                        result = number1 - number2;
                        break;
                    case 'x':
                    case 'X':
                    case '*':
                        result = number1 * number2;
                        break;
                    case '/':
                        result = number1 / number2;
                        break;
                }
                Console.WriteLine("Result: {0}", result);
            }
            else
                Console.WriteLine("Error in arguments");

        }
    }
}
