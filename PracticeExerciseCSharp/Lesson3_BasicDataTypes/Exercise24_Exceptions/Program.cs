using System;

namespace Exercise24_Exceptions
{
    internal class Program
    {
        /// <summary>
        /// Create a program to ask the user for a real number and display its square root. 
        /// Errors must be trapped using "try..catch".
        /// 
        /// Does it behave as you expected?
        /// </summary>
        static void Main(string[] args)
        {
            float result;
            float num;

            Console.Write("Enter Number ");
            try
            {
                num = Convert.ToSingle(Console.ReadLine());

                result = (float)Math.Sqrt(num);
                Console.WriteLine("The result is: {0}", result);
            }
            catch (Exception)
            {
                Console.WriteLine("Error, I cannot calculate the Square Root");
            }
        }
    }
}
