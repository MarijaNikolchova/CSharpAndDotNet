using System;

namespace Exercise09_DoubleReferenceParameters
{
    /// <summary>
    /// Create a function named "Double" to calculate the double of an integer number, 
    /// and modify the data passed as an argument. It must be a "void" function and you 
    /// must use "refererence parameters". For example.
    /// 
    /// x = 5;
    /// Double(ref x);
    /// Console.Write(x);
    /// 
    /// would display 10
    /// </summary>
    internal class Program
    {
        public static void Double(ref int n)
        {
            n = n + n;
        }

        public static void Main()
        {
            int x = 2;

            Double(ref x);
            Console.WriteLine(x);
        }
    }
}
