using System;

namespace Exercise37_PalindromeRecursive
{
    /// <summary>
    /// Create a recursive function to say whether a string is symmetric (a palindrome). 
    /// For example, "RADAR" is a palindrome.
    /// </summary>
    internal class Program
    {
        public static bool IsPalindrome(string text)
        {
            if (text.Length <= 1)
                return true;
            else
            {
                if (text[0] != text[text.Length - 1])
                    return false;
                else
                    return IsPalindrome(text.Substring(1, text.Length - 2));
            }
        }

        public static void Main()
        {
            Console.WriteLine(IsPalindrome("radar"));
            Console.WriteLine(IsPalindrome("pato"));
        }
    }
}
