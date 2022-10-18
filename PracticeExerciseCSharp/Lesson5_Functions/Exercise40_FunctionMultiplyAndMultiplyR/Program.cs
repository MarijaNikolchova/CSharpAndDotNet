using System;

namespace Exercise40_FunctionMultiplyAndMultiplyR
{
    /// <summary>
    /// Create two functions, Multiply and MultiplyR, to calculate the product of two numbers using sums. 
    /// T he first version must be iterative, and the second one must be recursive.
    /// </summary>
    internal class Program
    {
        public static int MultiplyR(int n1, int n2)
        {
            if (n2 == 0)
                return 0;
            else
                return n1 + MultiplyR(n1, n2 - 1);
        }

        public static int Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Enter two numbers!!");
                return 1;
            }
            else
            {
                int n1 = Convert.ToInt32(args[0]);
                int n2 = Convert.ToInt32(args[1]);

                Console.WriteLine(MultiplyR(n1, n2));
                return 0;
            }
        }
    }
}
