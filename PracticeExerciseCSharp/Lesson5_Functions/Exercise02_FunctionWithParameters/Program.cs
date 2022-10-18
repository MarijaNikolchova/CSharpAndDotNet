using System;

namespace Exercise02_FunctionWithParameters
{
    /// <summary>
    /// Create a program whose Main must be like this:
    /// 
    /// public static void Main()
    /// {
    /// SayHello("John");
    /// SayGoodbye();
    /// }
    /// 
    /// SayHello and SayGoodbye are functions that you must define and that will be called from inside Main.
    /// As you can see in the example.SayHello must accept an string as a parameter.
    /// </summary>
    internal class Program
    {
        public static void SayHello(string name)
        {
            Console.WriteLine("Hello" + name);
        }
        public static void SayGoodBye()
        {
            Console.WriteLine("Adios");
        }

        static void Main(string[] args)
        {
            SayHello("Jonh");
            SayGoodBye();
        }
    }
}
