﻿using System;

namespace Exercise30_Substrings_Hello_
{
    /// <summary>
    /// So you've registered. We sent you a welcoming email, to welcome you to code jam.But it's possible 
    /// that you still don't feel welcomed to code jam. That's why we decided to 
    /// name a problem "welcome to code jam."
    /// 
    /// After solving this problem, we hope that you'll feel very welcome. Very welcome, that is, to code jam.
    /// 
    /// If you read the previous paragraph, you're probably wondering why it's there. 
    /// But if you read it very carefully, you might notice that we have written the words 
    /// "welcome to code jam" several times: 400263727 times in total.After all, 
    /// it's easy to look through the paragraph and find a 'w'; then find an 'e' later in the paragraph; 
    /// then find an 'l' after that, and so on. Your task is to write a program that can take any text 
    /// and print out how many times that text contains the phrase "welcome to code jam".
    /// 
    /// To be more precise, given a text string, you are to determine how many times the string 
    /// "welcome to code jam" appears as a sub-sequence of that string. In other words, find a sequence s 
    /// of increasing indices into the input string such that the concatenation of input[s[0]], 
    /// input[s[1]], ..., input[s[18]] is the string "welcome to code jam". The result of your calculation 
    /// might be huge, so for convenience we would only like you to find the last 4 digits.
    /// 
    /// Input
    /// 
    /// The first line of input gives the number of test cases, N.
    /// The next N lines of input contain one test case each.Each test case is a single line of text, 
    /// containing only lower-case letters and spaces.No line will start with a space, 
    /// and no line will end with a space.
    /// 
    /// Output
    /// 
    /// For each test case, "Case #x: dddd", where x is the case number, and dddd is the last four digits of the answer.
    /// If the answer has fewer than 4 digits, please add zeroes at the front of your answer 
    /// to make it exactly 4 digits long.
    /// 
    /// Limits  
    /// 
    /// 1 ≤ N ≤ 100
    /// 
    /// Small dataset
    /// 
    /// Each line will be no longer than 30 characters.
    /// 
    /// Large dataset
    /// 
    /// Each line will be no longer than 500 characters.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
