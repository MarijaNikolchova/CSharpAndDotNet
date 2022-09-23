using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClassAndMethodToString
{
    public class Person
    {
        public string Name { get; set; } = String.Empty;
        public override string ToString()
        {
            return Name;
        }
    }
}
