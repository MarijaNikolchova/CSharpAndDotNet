using System;

namespace Exercise05_Calculator_if
{
    internal class Program
    {
        /// <summary>
        /// Write a program which asks the user for two numbers and an operation to perform 
        /// on them (+,-,*,x,/) and displays the result of that operation, as in this example:
        /// 
        /// Enter first number: 5
        /// Enter operation: +
        /// Enter second number: 7
        /// 5+7=12
        /// 
        /// Note: you MUST use "if", not "switch"
        /// </summary>
        static void Main(string[] args)
        {
            int a, b;
            char operation;

            Console.Write("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter operation: ");
            operation = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (operation == '+')
                Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            else if (operation == '-')
                Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            else if ((operation == 'x') || (operation == '*'))
                Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            else if (operation == '/')
                Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            else
                Console.WriteLine("Wrong Character");
        }
    }
}
