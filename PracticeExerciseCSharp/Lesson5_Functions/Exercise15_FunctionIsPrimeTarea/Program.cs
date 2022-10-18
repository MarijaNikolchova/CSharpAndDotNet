using System;

namespace Exercise15_FunctionIsPrimeTarea
{
    /// <summary>
    /// Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, 
    /// or false if it is not:
    /// 
    /// if (isPrime(127)) ...
    /// </summary>
    internal class Program
    {
        public static bool IsPrime(int n)
        {
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }

        public static void Main()
        {
            if (IsPrime(127))
                Console.WriteLine("127 is a prime number");
            else
                Console.WriteLine("127 is NOT a prime number");

            if (IsPrime(1000003))
                Console.WriteLine("1000003 is a prime number");
            else
                Console.WriteLine("1000003 is NOT a prime number");
        }
    }
}
