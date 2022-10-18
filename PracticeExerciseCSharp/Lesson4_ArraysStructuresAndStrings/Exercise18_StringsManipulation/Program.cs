using System;

namespace Exercise18_StringsManipulation
{
    /// <summary>
    /// Create a program that asks the user for a string and:
    /// 
    /// - Replace all lowercase A by uppercase A, except if they are preceded with a space
    /// - Display the initials(first letter and those after a space)
    /// - Display odd letters uppercase and even letter lowercase
    /// 
    /// The program must display all generated strings.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tell a string: ");
            string Entry = Console.ReadLine();
            string result;
            result = Entry.Replace("a", "A");
            Console.WriteLine(result);
            Console.WriteLine(UppercaseFirst(Entry));
        }
        public static string UppercaseFirst(string s)
        {
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
