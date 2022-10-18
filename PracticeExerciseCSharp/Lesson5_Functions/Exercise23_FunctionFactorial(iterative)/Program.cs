using System;

namespace Exercise23_FunctionFactorial_iterative_
{
    /// <summary>
    /// Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter:
    /// 
    /// Console.Write ( Factorial (6) );
    /// 
    /// would display
    /// 720
    /// </summary>
    internal class Program
    {
        public static float Factorial(int n)
        {
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static void Main()
        {
            Console.Write(Factorial(6));
        }
    }
}
