using System;

namespace Exercise4._07_Statistics
{
    /// <summary>
    /// Create a statistical program which will allow the user to:
    /// 
    /// - Add new data
    /// - See all data entered
    /// - Find an item, to see whether it has been entered or not
    /// - View a summary of statistics: amount of data, sum, average, maximum, minimum
    /// - Exit the program
    /// 
    /// These options must appear as a menu.Each option will be chosen by a number or a letter.
    /// 
    /// The program must reserve space for a maximum of 1000 data, but keep count of how many data actually exist.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] numbers = new float[1000];
            int count = 0;

            float max = 0.0f, min = 0.0f, total = 0.0f, searchNumber = 0.0f;
            bool found = default;

            int option;
            do
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Show");
                Console.WriteLine("3. Search");
                Console.WriteLine("4. Statistics");
                Console.WriteLine("5. Exit");

                option = Convert.ToInt32(Console.ReadLine());
                if (option != 5)
                {
                    switch (option)
                    {
                        case 1: // Add

                            Console.WriteLine("Enter a number: ");
                            numbers[count] = Convert.ToSingle(Console.ReadLine());

                            max = numbers[count];
                            min = numbers[count];

                            total += numbers[count];

                            count++;

                            if (max < numbers[count])
                                max = numbers[count];

                            if (min > numbers[count])
                                min = numbers[count];

                            break;
                        case 2: // Show

                            for (int i = 0; i < count; i++)
                                Console.WriteLine("{0} ", numbers[i]);

                            break;
                        case 3: // Search

                            Console.WriteLine("Enter a number for search: ");
                            searchNumber = Convert.ToSingle(Console.ReadLine());
                            int foundNum= 0;

                            for (int i = 0; i < count; i++)
                                if (numbers[i] == searchNumber)
                                {
                                    foundNum++;
                                    found = true;
                                }
                                    

                            if (found)
                                Console.WriteLine("Number {0} found a amount of {1} ", searchNumber, foundNum);
                            else
                                Console.WriteLine("Not found");

                            break;
                        case 4: // Statistics

                            Console.WriteLine("Total data: {0}", count + 1);
                            Console.WriteLine("Sum: {0}", total);
                            Console.WriteLine("Average: {0}", total / (count + 1));
                            Console.WriteLine("Min number: {0}", min);
                            Console.WriteLine("Max number: {0}", max);

                            break;
                        default:

                            Console.WriteLine("Error, option 1-5");
                            break;
                    }
                }
            }
            while (option != 5);
        }
    }
}
