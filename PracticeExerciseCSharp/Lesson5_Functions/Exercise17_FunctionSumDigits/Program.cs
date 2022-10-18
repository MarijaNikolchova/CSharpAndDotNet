using System;

namespace Exercise17_FunctionSumDigits
{
    /// <summary>
    /// Create a function SumDigits that receives a number and returns any results in the sum of its digits. 
    /// For example, if the number is 123, the sum would be 6.
    /// 
    /// Console.Write( SumDigits(123) );
    /// </summary>
    internal class Program
    {
        public static int SumDigits(int n)
        {
            string number = Convert.ToString(n);

            int sum = 0;

            for (int i = 0; i < number.Length; i++)
                sum += Convert.ToInt32(number.Substring(i, 1));

            return sum;
        }

        public static void Main()
        {
            Console.WriteLine(SumDigits(123));
        }
    }
}
