using System;

namespace Exercise14_Conversion
{
    internal class Program
    {
        /// <summary>
        /// Create a C# program to convert from celsius degrees to Kelvin and Fahrenheit: 
        /// it will ask the user for the amount of celsius degrees and using the following conversion tables:
        /// 
        /// kelvin = celsius + 273
        /// fahrenheit = celsius x 18 / 10 + 32
        /// </summary>
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
        }
    }
}
