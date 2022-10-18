using System;

namespace Exercise23_ComputerPrograms
{
    /// <summary>
    /// Create a C# program that can store up to 1000 records of computer programs. 
    /// For each program, you must keep the following data:
    /// 
    /// * Name
    /// * Category
    /// * Description
    /// * Version(is a set of 3 data: version number -text-, launch month -byte- and launch year -unsigned short-)
    /// 
    /// The program should allow the user the following operations:
    /// 1 - Add data of a new program(the name must not be empty, 
    /// category must not be more than 30 letters (or should be re-entered), and for the validation).
    /// 2 - Show the names of all the stored programs.Each name must appear on one line. 
    /// If there are more than 20 programs, you must pause after displaying each block of 20 programs, 
    /// and wait for the user to press Enter before proceeding.The user should be notified if there is no data.
    /// 3 - View all data for a certain program (from part of its name, category or description, case sensitive). 
    /// If there are several programs that contain that text, the program will display all of them, 
    /// separated by a blank line.The user should be notified if there are no matches found.
    /// 4 - Update a record(asking the user for the number, the program will display the previous value 
    /// of each field, and the user can press Enter not to modify any of the data). 
    /// He should be warned(but not asked again) if he enters an incorrect record number. 
    /// It is not necessary to validate any of the fields.
    /// 5 - Delete a record, whose number will be indicated by the user. 
    /// He should be warned (but not asked again) if he enters an incorrect number.
    /// 6 - Sort the data alphabetically by name.
    /// 7 - Fix redundant spaces (turn all the sequences of two or more spaces into a single space, 
    /// only in the name, for all existing records).
    /// X - Exit the application(as we do not store the information, data will be lost).
    /// </summary>
    internal class Program
    {
        struct versionType
        {
            public string number;
            public byte month;
            public ushort year;
        }

        struct program
        {
            public string name;
            public string category;
            public string description;
            public versionType version;
        }
        static void Main(string[] args)
        {
            int capacity = 1000;
            program[] data = new program[capacity];
            bool repeat = true;
            string option;
            int counter = 0;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Computer programas database");
                Console.WriteLine();
                Console.WriteLine("1.- Add data.");
                Console.WriteLine("2.- View names of the programs.");
                Console.WriteLine("3.- Search programs.");
                Console.WriteLine("4.- Modify program.");
                Console.WriteLine("5.- Delete Program.");
                Console.WriteLine("6.- Sort alphabetically");
                Console.WriteLine("7.- Fix redundant spaces");
                Console.WriteLine("0.-Exit.");
                Console.Write("Option: ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1": //add
                        if (counter > capacity - 1)
                        {
                            Console.WriteLine("Database full!");
                            break;
                        }

                        do
                        {
                            Console.Write("Enter Name: ");
                            data[counter].name = Console.ReadLine();
                            if (data[counter].name.Length == 0)
                                Console.Write("Cannot be empty");
                        } while (data[counter].name.Length == 0);

                        do
                        {
                            Console.Write("Enter category: ");
                            data[counter].category = Console.ReadLine();
                            if (data[counter].category.Length > 30)
                                Console.Write("Too long. 30 letters max, please");
                        } while (data[counter].category.Length > 30);

                        Console.Write("Enter Description: ");
                        data[counter].description = Console.ReadLine();
                        if (data[counter].description.Length > 100)
                            data[counter].description = data[counter].description.Substring(0, 100);

                        Console.Write("Enter the version number: ");
                        data[counter].version.number = Console.ReadLine();
                        Console.Write("Enter the version month: ");
                        data[counter].version.month = Convert.ToByte(Console.ReadLine());
                        Console.Write("Enter the version year: ");
                        data[counter].version.year = Convert.ToUInt16(Console.ReadLine());

                        counter++;
                        break;

                    case "2": //view
                        if (counter == 0)
                            Console.WriteLine("No data!");
                        else
                            for (int i = 0; i < counter; i++)
                            {
                                Console.WriteLine("{0}: {1}", i + 1, data[i].name);
                                if (i % 20 == 19)
                                {
                                    Console.Write("Press Enter...");
                                    Console.ReadLine();
                                }
                            }
                        break;

                    case "3": //search
                        Console.Write("Enter part of the name, description, etc... (case sensitive): ");
                        string search = Console.ReadLine();
                        bool found = false;
                        for (int i = 0; i < counter; i++)
                        {
                            if (data[i].name.Contains(search)
                                    || data[i].description.Contains(search)
                                    || data[i].category.Contains(search))
                            {
                                Console.WriteLine("{0}: {1}", i + 1, data[i].name);
                                found = true;
                            }
                        }
                        if (!found)
                            Console.WriteLine("Not found!");
                        break;

                    case "4":
                        Console.Write("Enter the program number: ");
                        int progNumber = Convert.ToInt32(Console.ReadLine()) - 1;

                        if ((progNumber > counter) || (progNumber < 0))
                        {
                            Console.Write("Out of range!");
                            break;
                        }

                        Console.Write("Program name (was {0}; hit ENTER to leave as is): ",
                            data[progNumber].name);
                        string newText = Console.ReadLine();
                        if (newText != "")
                            data[progNumber].name = newText;

                        Console.Write("Program category (was {0}; hit ENTER to leave as is): ",
                            data[progNumber].category);
                        newText = Console.ReadLine();
                        if (newText != "")
                            data[progNumber].category = newText;

                        Console.Write("Program description (was {0}; hit ENTER to leave as is): ",
                            data[progNumber].description);
                        newText = Console.ReadLine();
                        if (newText != "")
                            data[progNumber].description = newText;

                        Console.Write("Program version (number) (was {0}; hit ENTER to leave as is): ",
                            data[progNumber].version.number);
                        newText = Console.ReadLine();
                        if (newText != "")
                            data[progNumber].version.number = newText;

                        Console.Write("Program version (month) (was {0}; hit ENTER to leave as is): ",
                            data[progNumber].version.month);
                        newText = Console.ReadLine();
                        if (newText != "")
                            data[progNumber].version.month = Convert.ToByte(newText);

                        Console.Write("Program version (year) (was {0}; hit ENTER to leave as is): ",
                            data[progNumber].version.year);
                        newText = Console.ReadLine();
                        if (newText != "")
                            data[progNumber].version.year = Convert.ToUInt16(newText);


                        break;

                    case "5": //delete
                        int position = 0;
                        Console.Write("Enter the position number to delete: ");
                        position = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (position > counter)
                            Console.WriteLine("Error: out of range");
                        else
                        {
                            for (int i = position; i < counter; i++)
                                data[i] = data[i + 1];
                            counter--;
                        }
                        break;

                    case "6": // Sort
                        program aux;
                        for (int i = 0; i < counter - 1; i++)
                        {
                            for (int j = i + 1; j < counter; j++)
                            {
                                if (data[i].name.CompareTo(data[j].name) > 0)
                                {
                                    aux = data[i];
                                    data[i] = data[j];
                                    data[j] = aux;
                                }
                            }
                        }
                        break;

                    case "7": //replace "  " x " "
                        for (int i = 0; i < counter; i++)
                        {
                            while (data[i].name.Contains("  "))
                                data[i].name = data[i].name.Replace("  ", " ");
                        }
                        break;

                    case "0":
                        repeat = false;
                        break;

                    default:
                        Console.WriteLine("Wrong option!");
                        break;
                }
            }
            while (repeat != false);
        }
    }
}
