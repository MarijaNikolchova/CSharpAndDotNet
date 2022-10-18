using System;

namespace Exercise16_ParametersOfMainSum
{
    /// <summary>
    /// Create a program named "sum", which receives two integer numbers in the command line and displays their sum, 
    /// as in this example:
    /// 
    /// sum 5 3
    /// 8
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 2)
                Console.WriteLine(Convert.ToInt32(args[0]) + Convert.ToInt32(args[1]));
            else
                Console.WriteLine("Two numbers, please");
        }
    }
}
