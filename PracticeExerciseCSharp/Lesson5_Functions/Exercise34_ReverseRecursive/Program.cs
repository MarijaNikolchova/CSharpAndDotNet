using System;

namespace Exercise34_ReverseRecursive
{
    /// <summary>
    /// Create a program that uses recursion to reverse a string of characters 
    /// (for example, from "Hello" it would return "olleH").
    /// </summary>
    internal class Program
    {
        public static string Reverse(string text)
        {
            if (text.Length <= 1)
                return text;

            char firstLetter = text[0];
            string rest = text.Substring(1);


            return Reverse(rest) + firstLetter;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Reverse("Juan"));
        }
    }
}
