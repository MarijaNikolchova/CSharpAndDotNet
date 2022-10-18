using System;

namespace Exercise19_ParametersOfMainReverse
{
    /// <summary>
    /// Create a program named "reverse", which receives several words in the command line and displays 
    /// them in reverse order, as in this example:
    /// 
    /// reverse one two three
    /// three two one
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = args.Length - 1; i >= 0; i--)
            {
                Console.Write(args[i]);
                Console.Write(" ");
            }
        }
    }
}
