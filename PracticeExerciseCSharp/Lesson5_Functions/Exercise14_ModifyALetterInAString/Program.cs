using System;

namespace Exercise14_ModifyALetterInAString
{
    /// <summary>
    /// Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, 
    /// replacing it with a different letter:
    /// 
    /// string sentence = "Tomato";
    /// ChangeChar(ref sentence, 5, 'a');
    /// </summary>
    internal class Program
    {
        public static void ChangeChar(ref string text, int position, char letter)
        {
            text = text.Remove(position, 1);
            text = text.Insert(position, letter.ToString());
        }

        public static void Main()
        {
            string sentence = "Tomato";
            ChangeChar(ref sentence, 5, 'a');
        }
    }
}
