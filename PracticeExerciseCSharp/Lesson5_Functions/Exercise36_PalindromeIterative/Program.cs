using System;

namespace Exercise36_PalindromeIterative
{
    /// <summary>
    /// Create an iterative function to say whether a string is symmetric (a palindrome). 
    /// For example, "RADAR" is a palindrome.
    /// </summary>
    internal class Program
    {
        public static bool IsPalindrome(string text)
        {
            text = text.ToUpper();

            int begin = 0;
            int end = text.Length - 1;

            for (begin = 0; begin < end; begin++)
            {
                if (text[begin] != text[end])
                    return false;
                end--;
            }

            return true;
        }

        public static void Main()
        {
            Console.WriteLine(IsPalindrome("radar"));
            Console.WriteLine(IsPalindrome("ratas"));
        }
    }
}
