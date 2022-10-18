using System;

namespace Exercise03_TableCoffetableArray
{
    internal class Table
    {
        protected float width, height;

        public Table() { }

        public Table(float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        public float Width
        {
            set { width = value; }
            get { return width; }
        }
        public float Height
        {
            set { height = value; }
            get { return height; }
        }

        public virtual void ShowData()
        {
            Console.WriteLine("Width: {0}, Heigth: {1}", width, height);
        }
    }
}