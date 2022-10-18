using System;

namespace Exercise11_FunctionPowerLocalVariables
{
    /// <summary>
    /// Create a function named "Power" to calculate the result of raising an integer number to another 
    /// (positive integer) number. It must return another integer number. For example. Power(2,3) should return 8.
    /// 
    /// Note: You MUST use a repetitive structure, such as "for " or "while", you cannot use Math.Pow.
    /// </summary>
    internal class Program
    {
        public static void Main()
        {
            int number;
            int exponent;

            Console.Write("Base: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Exponent: ");
            exponent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}^{1}={2}", number, exponent, Power(number, exponent));
        }

        public static int Power(int number, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
                result *= number;

            return result;
        }
    }
}
