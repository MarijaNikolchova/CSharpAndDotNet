using System;

namespace Exercise03_TableCoffetableArray
{
    /// <summary>
    /// Create a project named "Tables2", based on the "Tables" project.
    /// 
    /// In it, create a class "CoffeeTable" that inherits from "Table". 
    /// Its method “ShowData", besides writing the width and height, must display "(Coffee table)."
    /// 
    /// Create an array that contains 5 tables and 5 coffee tables.
    /// The tables must have random sizes between 50 and 200 cm, and the coffee tables from 40 to 120 cm.
    /// Show all their data.
    /// </summary>
    internal class TestTables
    {
        static void Main(string[] args)
        {
            bool debug = false;

            Table[] myTables = new Table[10];
            Random rnd = new Random();

            for (int i = 1; i <= 10; i++)
            {
                if ((i % 2 == 0) && (i != 1))
                {
                    myTables[i - 1] = new Table(rnd.Next(50, 201), rnd.Next(50, 201));
                    myTables[i - 1].ShowData();
                }
                else
                {
                    myTables[i - 1] = new CoffeeTable(rnd.Next(40, 121), rnd.Next(40, 121));
                    myTables[i - 1].ShowData();
                }

            }

            if (debug)
                Console.ReadLine();
        }
    }
}
