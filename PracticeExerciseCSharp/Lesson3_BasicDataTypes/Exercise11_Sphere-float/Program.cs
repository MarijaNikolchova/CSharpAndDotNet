using System;

namespace Exercise11_Sphere_float
{
    internal class Program
    {
        /// <summary>
        /// Calculate the surface and volume of a sphere, given its radius 
        /// (surface = 4 * pi* radius squared; volume = 4/3 * pi * radius cubed).
        /// 
        /// Hint: for "float" numbers, you must use Convert.ToSingle(...)
        /// </summary>
        static void Main(string[] args)
        {
            float radius;
            float pi = 3.1415926535f;

            Console.Write("Radius? ");
            radius = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(4 * pi * (radius * radius));

            Console.WriteLine(4 / 3 * pi * (radius * radius * radius));
        }
    }
}
