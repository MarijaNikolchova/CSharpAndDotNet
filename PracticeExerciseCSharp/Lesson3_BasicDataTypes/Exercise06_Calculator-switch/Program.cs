using System;

namespace Exercise06_Calculator_switch
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
        /// Note: you MUST use "switch", not "if"
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

            switch (operation)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
                    break;
                case '-':
                    Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
                    break;
                case 'x':
                case '*':
                    Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
                    break;
                case '/':
                    Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
                    break;
                default:
                    Console.WriteLine("Wrong Character");
                    break;
            }
        }
    }
}
