using System;

namespace Exercise06_TableCoffetableLeg
{
    internal class CoffeeTable : Table
    {
        public CoffeeTable(int tableWidth, int tableHeight)
           : base(tableWidth, tableHeight)
        {
        }

        public override void ShowData()
        {
            Console.WriteLine("Width: {0}, Height: {1}", width, height);
            Console.WriteLine("(Coffee table)");
        }
    }
}