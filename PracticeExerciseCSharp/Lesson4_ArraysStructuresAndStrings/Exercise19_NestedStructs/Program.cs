using System;

namespace Exercise19_NestedStructs
{
    /// <summary>
    /// Create a struct to store two data for a person: name and date of birth. 
    /// The date of birth must be another struct consisting on day, month and year. 
    /// Finally, create an array of persons, ask the user for the dat of two persons and display them.
    /// </summary>
    internal class Program
    {
        struct person
        {
            public string Name;
            public dateBirth Date;
        }

        struct dateBirth
        {
            public int Day;
            public int Month;
            public int Year;
        }
        static void Main(string[] args)
        {
            int d = 0, m = 0, y = 0;
            int total = 1;
            person[] p = new person[total];

            for (int i = 0; i <= total; i++)
            {
                Console.Write("Enter name: ");
                string Name = Console.ReadLine();
                Console.WriteLine();
                p[i].Name = Name;

                Console.Write("Enter day: ");
                d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                p[i].Date.Day = d;

                Console.Write("Enter month: ");
                d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                p[i].Date.Month = m;

                Console.Write("Enter year: ");
                d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                p[i].Date.Year = y;
            }
        }
    }
}
