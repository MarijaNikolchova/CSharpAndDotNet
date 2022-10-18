using System;

namespace Exercise27_FunctionCountDV
{
    /// <summary>
    /// Create a function that calculates the amount of numeric digits and vowels that a text string contains. 
    /// It will accept three parameters: the string that we want to search, 
    /// the variable that returns the number of digits, and the number of vowels, in that order). 
    /// The function should be called "CountDV". Use it like this:
    /// 
    /// CountDV("This is the phrase 12", ref amountOfDigits, ref amountOfVowels)
    /// 
    /// In this case, amountOfDigits would be 2 and amountOfVowels would be 5
    /// </summary>
    internal class Program
    {
        public static void CountDV(string answer, ref int amountOfDigits, ref int amountOfVowels)
        {
            amountOfDigits = 0;
            amountOfVowels = 0;

            for (int i = 0; i < answer.Length; i++)
            {
                switch (answer.Substring(i, 1).ToLower())
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u":
                        amountOfVowels++;
                        break;
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                        amountOfDigits++;
                        break;
                }
            }
        }

        public static void Main()
        {
            int amountOfDigits = 0;
            int amountOfVowels = 0;

            CountDV("This", ref amountOfDigits, ref amountOfVowels);

            Console.WriteLine(amountOfDigits);
            Console.WriteLine(amountOfVowels);
        }
    }
}
