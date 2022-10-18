using System;

namespace Exercise04_FunctionReturningAValue2
{
    /// <summary>
    /// Create a program whose Main must be like this:
    /// 
    /// public static void Main()
    /// {
    /// Console.WriteLine("\"Hello, how are you\" contains {0} spaces", CountSpaces("Hello,how are you"));
    /// }
    /// 
    /// CountSpaces is a function that you must define and that will be called from inside Main.
    /// 
    /// As you can see in the example, it must accept an string as a parameter, 
    /// and it must return an integer number (the amount of spaces in that string).
    /// </summary>
    internal class Program
    {
        public static int CountSpaces(string text)
        {
            int countSpaces = 0;
            string letter;
            for (int i = 0; i < text.Length; i++)
            {
                letter = text.Substring(i, 1);
                if (letter == " ")
                    countSpaces++;
            }
            return countSpaces;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\"Hello, how are you\" contains {0} spaces",
            CountSpaces("Hello, how are you"));
        }
    }
}
