using System;

namespace Exercise32_CalculatorParamsAndReturnValueOfMain
{
    /// <summary>
    /// Create a program to calculate a sum, subtraction, product or division, analyzing the command line parameters:
    /// 
    /// calc 5 + 379
    /// 
    /// (Parameters must be a number, a sign, and another number; allowed signs are + - * x / )
    /// 
    /// This version must return the following error codes:
    /// 1 if the number of parameters is not 3
    /// 2 if the second parameter is not an accepted sign
    /// 3 if the first or third parameter is not a valid number
    /// 0 otherwise
    /// </summary>
    internal class Program
    {
        public static int Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Error!");
                Console.WriteLine("Usage: number1 operand number2");
                Console.WriteLine("Where operand can be + - / * x ·");
                return 1;
            }

            try
            {
                int number1 = Convert.ToInt32(args[0]);
                int number2 = Convert.ToInt32(args[2]);

                switch (args[1])
                {
                    case "+":
                        {
                            Console.WriteLine(number1 + number2);
                            break;
                        }

                    case "-":
                        {
                            Console.WriteLine(number1 - number2);
                            break;
                        }

                    case "/":
                        {
                            Console.WriteLine(number1 / number2);
                            break;
                        }

                    case "*":
                    case "x":
                    case "·":
                        {
                            Console.WriteLine(number1 * number2);
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Error!");
                            Console.WriteLine("Operand must be + - / * x or ·");
                            return 2;
                            break;
                        }
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Error!");
                Console.WriteLine("Not a valid number");
                return 3;
            }

            return 0;
        }
    }
}
