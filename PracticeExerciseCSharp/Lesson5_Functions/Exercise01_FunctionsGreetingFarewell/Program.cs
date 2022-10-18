using System;

namespace Exercise01_FunctionsGreetingFarewell
{
    /// <summary>
    /// Create a program whose Main must be like this:
    /// 
    /// public static void Main()
    /// {
    /// SayHello();
    /// SayGoodbye();
    /// }
    /// 
    /// SayHello and SayGoodbye are functions that you must define and that will be called from inside Main.
    /// </summary>
    internal class Program
    {
        public static void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        public static void SayGoodbye()
        {
            Console.WriteLine("Good Bye!");
        }

        static void Main(string[] args)
        {
            SayHello();
            SayGoodbye();
        }
    }
}
