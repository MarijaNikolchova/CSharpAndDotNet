using System;

namespace Exercise28_FunctionIsAlphabetic
{
    /// <summary>
    /// Create a function that tells if a character is alphabetic (A through Z) or not. It should be used like this:
    /// 
    /// if (IsAlphabetic ('a'))
    /// System.Console.WriteLine ("It is an alphabetic character");
    /// 
    /// (Note: do not worry about accents and ñ)
    /// </summary>
    internal class Program
    {
        public static bool IsAlpha(char simbolo)
        {
            if ((simbolo >= 'a') && (simbolo <= 'z'))
                return true;

            if ((simbolo >= 'A') && (simbolo <= 'Z'))
                return true;

            return false;
        }

        public static bool IsAlpha2(char simbolo)
        {
            simbolo = Char.ToLower(simbolo);
            if ((simbolo >= 'a') && (simbolo <= 'z'))
                return true;

            return false;
        }

        public static bool IsAlpha3(char simbolo)
        {
            simbolo = simbolo.ToString().ToLower()[0];
            if ((simbolo >= 'a') && (simbolo <= 'z'))
                return true;

            return false;
        }

        public static bool IsAlpha4(char simbolo)
        {
            string validas = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqwrstuvwxyz";
            if (validas.Contains(simbolo))
                return true;

            return false;
        }

        public static void Main()
        {
            Console.WriteLine(
             IsAlpha('w'));
            Console.WriteLine(
             IsAlpha('2'));
        }
    }
}
