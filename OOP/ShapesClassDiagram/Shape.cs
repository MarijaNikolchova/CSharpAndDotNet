using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesClassDiagram
{
    public abstract class Shape
    {
        protected Location Location { get; set; }

        public Shape(double x , double y)
        {
            Location = new Location();
            Location.x = x;
            Location.y = y;
        }
        public override string ToString()
        {
            return $"x : {Location.x} y : {Location.y}";
        }

        public abstract double Area();

        public abstract double Perimeter();
    }
}
