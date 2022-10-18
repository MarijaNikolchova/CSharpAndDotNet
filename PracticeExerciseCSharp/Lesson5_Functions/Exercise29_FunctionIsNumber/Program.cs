using System;

namespace Exercise29_FunctionIsNumber
{
    /// <summary>
    /// Create a function that tells if a string is an intenger number. It should be used like this:
    /// 
    /// if (IsNumber ("1234"))
    /// System.Console.WriteLine ("It is a numerical value");
    /// </summary>
    internal class Program
    {
        public static bool IsNumber(string text)
        {
            for (int i = 0; i < text.Length; i++)
                if ((text[i] < '0') || (text[i] > '9'))
                    return false;

            return true;
        }


        public static void Main()
        {
            Console.WriteLine(IsNumber("12"));
        }
    }
}
