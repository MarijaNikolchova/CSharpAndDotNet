using System;

namespace Exercise20_GetInt
{
    /// <summary>
    /// Create a function named "GetInt", which displays on screen the text received as a parameter, 
    /// asks the user for an integer number, repeats if the number is not between the minimum value 
    /// and the maximum value which are indicated as parameters, and finally returns the entered number:
    /// 
    /// age = GetInt("Enter your age", 0, 150);
    /// 
    /// would become:
    /// 
    /// Enter your age: 180
    /// Not a valid answer.Must be no more than 150.
    /// Enter your age: -2
    /// Not a valid answer. Must be no less than 0.
    /// Enter your age: 20
    /// 
    /// (the value for the variable "age" would be 20)
    /// </summary>
    internal class Program
    {
        public static int getInt(string text, int low, int high)
        {
            int answer;
            do
            {
                Console.Write(text);
                answer = Convert.ToInt32(Console.ReadLine());
                if ((answer > high))
                    Console.WriteLine("Not a valid answer. Must be no more than 150");
                if ((answer < low))
                    Console.WriteLine("Not a valid answer. Must be no less than 0");
            } while ((answer < low) || (answer > high));
            return answer;
        }


        static void Main()
        {
            int age = getInt("Enter your age:  ", 0, 150);
            Console.WriteLine("The age is {0}", age);
        }
    }
}
