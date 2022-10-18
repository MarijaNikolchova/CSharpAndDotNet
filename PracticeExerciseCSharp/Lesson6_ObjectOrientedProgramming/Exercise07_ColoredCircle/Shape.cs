using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07_ColoredCircle
{
    internal class Shape
    {
        protected Location c;

        public string ToString()
        {
            return "";
        }

        public virtual double Area()
        {
            return 0.000;
        }

        public virtual double Perimeter()
        {
            return 0.000;
        }
    }
}
