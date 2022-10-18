using System;

namespace Exercise18_Double_ApproximationOfPi
{

    internal class Program
    {
        /// <summary>
        /// Create a program to calculate an approximation for PI using the expression 
        ///  
        /// pi/4 = 1/1 - 1/3 + 1/5 -1/7 + 1/9 - 1/11 + 1/13 ... 
        ///  
        /// The user will indicate how many terms must be used, and the program will displayb all the results until that amount of terms.
        /// </summary>
        static void Main(string[] args)
        {
            int terms;
            double result = 0;

            Console.WriteLine("PI estimator!");
            Console.Write("Enter the amount of terms to test: ");
            terms = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= terms; i++)
            {
                int divisor = 2 * i - 1;
                if (i % 2 == 1)
                    result += 1.0f / divisor;
                else
                    result -= 1.0f / divisor;

                Console.WriteLine("To term {0}: {1}",
                  i, 4 * result);
            }
        }
    }
}
