using System;

namespace Exercise31_CondOperator_PositiveAndSmaller
{
    internal class Program
    {
        /// <summary>
        /// Create a C# program which asks the user for two numbers and answers, using the conditional operator (?), the following:
        /// 
        /// - If the first number is positive
        /// - If the second number is positive
        /// - If they are both positive
        /// - Which one is smaller
        /// </summary>
        static void Main(string[] args)
        {
            int a, b;
            string answer;

            Console.Write("Enter the first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > 0)
                Console.WriteLine("a is positive");
            else
                Console.WriteLine("a is not positive");

            if (a > 0)
                answer = "a is positive";
            else
                answer = "a is not positive";
            Console.WriteLine(answer);

            answer = a > 0 ? "a is positive" : "a is not positive";
            Console.WriteLine(answer);

            Console.WriteLine(b > 0 ?
                "b is positive" : "b is not positive");

            answer = (a > 0) && (b > 0) ?
                "both are positive" : "not both are positive";
            Console.WriteLine(answer);

            int smallest = a < b ? a : b;
            Console.WriteLine("Smallest: {0}", smallest);
        }
    }
}
