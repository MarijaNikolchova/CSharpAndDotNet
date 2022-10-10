using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAgain
{
    internal class Hello
    {
        public string name { get; set; }

        public Hello (string _name)
        {
            this.name = _name;
        }

        public void sayHello()
        {
            Console.WriteLine("Hello" + name);
        }
    }
}
