using System;

namespace Exercise06_TableCoffetableLeg
{
    internal class Leg
    {
        Table myTable;
        public Leg() { }

        public void SetTable(Table t)
        {
            myTable = t;
        }

        public void ShowData()
        {
            Console.WriteLine("I am a leg");
            myTable.ShowData();
        }
    }
}