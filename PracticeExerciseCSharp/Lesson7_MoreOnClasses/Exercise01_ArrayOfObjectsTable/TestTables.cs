using System;

namespace Exercise01_ArrayOfObjectsTable
{
    /// <summary>
    /// Create a class named "Table". It must have a constructor, indicating the width and height of the board. 
    /// It will have a method "ShowData" which will write on the screen the width and that height of the table. 
    /// Create an array containing 10 tables, with random sizes between 50 and 200 cm, and display all the data.
    /// </summary>
    internal class TestTables
    {
        static void Main(string[] args)
        {
            bool debug = false;

            Table[] myTables = new Table[10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                myTables[i] = new Table(rnd.Next(50, 201), rnd.Next(50, 201));
                myTables[i].ShowData();
            }

            if (debug)
                Console.ReadLine();
        }
    }
}
