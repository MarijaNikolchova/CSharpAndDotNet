using System;

namespace Exercise05_ManyNumbersAndSum
{
    /// <summary>
    /// Create a program which asks the user for several numbers (until he enters "end" and displays their sum).
    /// When the execution is going to end, it must display all the numbers entered, and the sum again, 
    /// as follows:
    /// 
    /// Enter a number: 5
    /// Sum = 5
    /// Enter a number: 3
    /// Sum = 8
    /// Enter a number: end
    /// The numbers are: 5 3
    /// The sum is: 8
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] numbers = new float[1000];
            string entrada = "";
            float sum = 0;
            int counter = 0;

            while (entrada.ToLower() != "end" || numbers[999] != default)
            {
                Console.Write("Enter a number: ");
                entrada = Console.ReadLine();

                if (entrada.ToLower() == "end")
                    break;

                bool isNumber = float.TryParse(entrada, out float result);
                if (isNumber)
                    numbers[counter] = result;

                sum += numbers[counter];

                counter++;

                Console.Write("The sum is: ");
                Console.Write(sum);
                Console.WriteLine();
            }

            string sumNumbers = "";

            foreach (float num in numbers)
                if (num != default)
                    sumNumbers += num + ", ";

            sumNumbers = sumNumbers.Remove(sumNumbers.Length - 2);

            Console.Write("The numbers are: ");
            Console.WriteLine(sumNumbers);

            Console.Write("The sum is: ");
            Console.Write(sum);
        }
    }
}
