using System;

namespace Exercise26_Product
{
    internal class Program
    {
        /// <summary>
        /// Create a program which asks the user for two integer numbers and displays their multiplication,
        /// but not using "*". You must use consecutive sums. (Hint: remember that 3*5 = 3+3+3+3+3 = 15)
        /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int result = 0;
            int i = 0;

            while (i < n2)
            {
                result = result + n1;
                i++;
            }
            Console.WriteLine("{0} X {1} = {2}", n1, n2, result);
        }
    }
}
