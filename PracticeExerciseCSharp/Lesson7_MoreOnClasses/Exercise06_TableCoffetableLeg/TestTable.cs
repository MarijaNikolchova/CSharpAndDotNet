using System;

namespace Exercise06_TableCoffetableLeg
{
    /// <summary>
    /// Extend the example of the tables and the coffee tables, 
    /// to add a class "Leg" with a method "ShowData", which will write 
    /// "I am a leg" and then it will display the data of the table to which it belongs.
    /// 
    /// Choose one table in the example, add a leg to it and ask that leg to display its data.
    /// </summary>
    internal class TestTable
    {
        static void Main(string[] args)
        {
            // Using as a single table:

            Table t = new Table(80, 120);
            Leg l = new Leg();
            t.AddLeg(l);
            l.ShowData();

            Console.WriteLine();

            // Using as array:

            Table[] tableList = new Table[10];
            Random random = new Random();

            for (int i = 0; i < tableList.Length; i++)
            {
                if (i < tableList.Length / 2)
                    tableList[i] = new Table(
                        random.Next(50, 201),
                        random.Next(50, 201));
                else
                    tableList[i] = new CoffeeTable(
                        random.Next(40, 121),
                        random.Next(40, 121));
            }

            for (int i = 0; i < tableList.Length; i++)
            {
                tableList[i].ShowData();
            }

            // TODO: To be removed
            Console.ReadLine();
        }
    }
}
