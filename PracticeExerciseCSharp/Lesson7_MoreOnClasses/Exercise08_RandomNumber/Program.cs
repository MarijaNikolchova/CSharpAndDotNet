using System;

namespace Exercise08_RandomNumber
{
    /// <summary>
    /// Create a class RandomNumber, with three static methods:
    /// 
    /// - GetFloat will return a number between 0 and 1 using the following algorithm:
    /// 
    /// seed = (seed* a + c) % m
    /// result = abs(seed / m)
    /// 
    /// - GetInt(max) will return a number from 0 to max, using:
    /// result = round(max* GetFloat)
    /// 
    /// - GetInt(min, max) will return a number from min to max(you must create this one totally on your own).
    /// 
    /// The starting values must be:
    /// m = 233280;
    /// a = 9301;
    /// c = 49297;
    /// seed = 1;
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
