using System;

namespace Exercise11_Age
{
    internal class Program
    {
        /// <summary>
        /// Write a C# program to ask the user for his age (20, for instance) 
        /// and answer something as "You look younger than 20" (instead of 20, 
        /// you should display the age that has been entered).
        /// </summary>
        static void Main(string[] args)
        {
            int age;
            Console.Write("Enter a age ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("You look younger than {0} ", age);
        }
    }
}
