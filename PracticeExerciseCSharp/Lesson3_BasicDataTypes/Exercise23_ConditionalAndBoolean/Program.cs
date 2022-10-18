using System;

namespace Exercise23_ConditionalAndBoolean
{
    internal class Program
    {
        /// <summary>
        /// Create a program that uses the conditional operator to give a boolean variable named 
        /// "bothEven" the value "true" if two numbers entered by the user are the even, 
        /// or "false" if any of them is odd.
        /// </summary>
        static void Main(string[] args)
        {
            int num1, num2;
            bool bothEven;
            Console.Write("Enter First number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            bothEven = ((num1 % 2 == 0)
                && (num2 % 2 == 0)) ? true : false;

            Console.WriteLine(bothEven ?
              "there're numbers bothEven" :
              "there's a number odd");
        }
    }
}
