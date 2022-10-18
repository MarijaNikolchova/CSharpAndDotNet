using System;

namespace Exercise12_RecursivePower
{
    /// <summary>
    /// Create a function that calculates the result of raising an integer to another integer 
    /// (eg 5 raised to 3 = 53 = 5 × 5 × 5 = 125). This function must be created recursively.
    /// 
    /// An example of use would be: Console.Write(Power(5,3) );
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

            Console.WriteLine("{0}^{1}={0}", Power(number, exponent));
        }

        public static int Power(int number, int exponent)
        {
            if (exponent == 0)
                return 1;
            else
                return number * Power(number, exponent - 1);
        }
    }
}
