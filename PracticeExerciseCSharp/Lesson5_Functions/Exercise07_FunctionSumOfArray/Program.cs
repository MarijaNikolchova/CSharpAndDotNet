using System;

namespace Exercise07_FunctionSumOfArray
{
    /// <summary>
    /// Create a C# program to calculate the sum of the elements in an array. "Main" should be like this:
    /// 
    /// public static void Main()
    /// {
    /// int[] example = { 20, 10, 5, 2 };
    /// Console.WriteLine("The sum of the example array is {0}", Sum(example));
    /// }
    /// </summary>
internal class Program
    {
        public static int Sum(int[] example)
        {
            int total = 0;
            for (int i = 0; i < example.Length; i++)
                total += example[i];
            return total;
        }

        public static void Main()
        {
            int[] example = { 20, 10, 5, 2 };
            Console.WriteLine("The sum of the example array is {0}", Sum(example));
        }
    }
}
