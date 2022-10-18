using System;

namespace Exercise06_TableCoffetableLeg
{
    internal class Table
    {
        protected int width, height;
        protected Leg myLeg;
        public Table(int tableWidth, int tableHeight)
        {
            width = tableWidth;
            height = tableHeight;
        }

        public void AddLeg(Leg l)
        {
            myLeg = l;
            myLeg.SetTable(this);
        }

        public virtual void ShowData()
        {
            Console.WriteLine("Width: {0}, Height: {1}", width, height);
        }
    }
}