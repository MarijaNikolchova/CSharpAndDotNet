using System;

namespace Exercise18_FunctionFactorial
{
    /// <summary>
    /// The factorial of a number is expressed as follows:
    /// 
    /// n! = n · (n-1) · (n-2) · (n-3) · ... · 3 · 2 · 1
    /// 
    /// For example,
    /// 6! = 6·5·4·3·2·1
    /// 
    /// Create a recursive function to calculate the factorial of the number specified as parameter:
    /// 
    /// Console.Write(Factorial (6) );
    /// 
    /// would display 720
    /// </summary>
    internal class Program
    {
        public static int Factorial(int num)
        {
            if (num == 0)
                return 1;
            else
                return num * Factorial(num - 1);
        }

        public static void Main()
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Factorial(number));

            Console.WriteLine(Factorial(6));
        }
    }
}
