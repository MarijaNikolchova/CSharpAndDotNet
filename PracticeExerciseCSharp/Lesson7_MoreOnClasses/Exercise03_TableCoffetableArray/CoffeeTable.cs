using System;

namespace Exercise03_TableCoffetableArray
{
    internal class CoffeeTable : Table
    {
        public CoffeeTable(float width, float height)
        {
            this.width = width;
            this.height = height;
        }
        public override void ShowData()
        {
            Console.WriteLine("(Coffee table) Width: {0}, Heigth: {1}", width, height);
        }
    }
}