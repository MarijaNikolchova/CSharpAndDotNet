using System;

namespace Exercise25_HouseholdAccounts
{
    /// <summary>
    /// Create a program in C # that can store up to 10000 costs and revenues, 
    /// to create a small domestic accounting system. For each expense (or income), 
    /// should be allowed to save the following information:
    /// 
    /// • Date(8 characters: YYYYMMDD format)
    /// • Description of expenditure or revenue
    /// • Category
    /// • Amount(if positive income, negative if an expense)
    /// 
    /// The program should allow the user to perform the following operations:
    /// 
    /// 1 - Add a new expense(the date should "look right": day 01 to 31 months from 01 to 12 years 
    /// between 1000 and 3000). The description must not be empty.Needless to validate the other data.
    /// 
    /// 2 - Show all expenses of a certain category (eg, "studies") between two certain 
    /// dates(eg between "20110101" and "20111231"). Number is displayed, date(format DD / MM / YYYY), 
    /// description, category in parentheses, and amount to two decimal places, all in the same line, 
    /// separated by hyphens.At the end of all data show the total amount of data displayed.
    /// 
    /// 3 - Search costs containing a certain text(in the description or category without 
    /// distinguishing case sensitive). Number is displayed, the date and description(the description is 
    /// displayed in the sixth truncated blank, if any spaces six or more).
    /// 
    /// 4 - Modify a tab(tab number prompt the user, it will show the previous value of each field and press 
    /// Enter to not be able to modify any of the data). Should be advised(but not re-order) if the user 
    /// enters a wrong card number.Needless to validate any data.
    /// 
    /// 5 - Delete some data, from the number that you enter.Should be advised (but not re-order) 
    /// if you enter an incorrect number.It should show the card to be clear and prompt prior to deletion.
    /// 
    /// 6 - Sort data alphabetically, by date and(if matched) description.
    /// 
    /// 7 - Normalize descriptions: remove trailing spaces, spaces and mirror sites. 
    /// If a description is all uppercase, will be converted to lowercase (except for the first letter,
    /// kept in uppercase).
    /// 
    /// T-End the use of the application(as we store the information, the data will be lost).
    /// </summary>
    internal class Program
    {
        struct accountData
        {
            public string date;
            public string description;
            public string category;
            public double amount;
        }
        static void Main(string[] args)
        {
            int capacity = 10000;
            accountData[] data = new accountData[capacity];
            bool repeat = true;
            string option;
            int amountOfData = 0;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Household accounts");
                Console.WriteLine();
                Console.WriteLine("1.- Add data.");
                Console.WriteLine("2.- View all data.");
                Console.WriteLine("3.- Search data.");
                Console.WriteLine("4.- Modify data.");
                Console.WriteLine("5.- Delete data.");
                Console.WriteLine("6.- Sort alphabetically");
                Console.WriteLine("7.- Fix spaces");
                Console.WriteLine("Q,T.-Quit.");
                Console.Write("Option: ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1": //add
                        if (amountOfData > capacity - 1)
                            Console.WriteLine("Database full!");
                        else
                        {
                            do
                            {
                                Console.Write("Enter date (YYYYMMDD): ");
                                data[amountOfData].date = Console.ReadLine();
                                // TODO: Individual validation for the date
                            } while (data[amountOfData].date.Length == 0);

                            do
                            {
                                Console.Write("Enter Description: ");
                                data[amountOfData].description = Console.ReadLine();
                                if (data[amountOfData].description.Length == 0)
                                    Console.Write("Cannot be empty");
                            } while (data[amountOfData].description.Length == 0);

                            Console.Write("Enter category: ");
                            data[amountOfData].category = Console.ReadLine();

                            Console.Write("Enter the amount: ");
                            data[amountOfData].amount = Convert.ToDouble(Console.ReadLine());

                            amountOfData++;
                        }
                        break;

                    case "2": //view
                        if (amountOfData == 0)
                            Console.WriteLine("No data!");
                        else
                        {
                            Console.Write("Enter the category: ");
                            string categ = Console.ReadLine();
                            Console.Write("Enter the start date (YYYYMMDD): ");
                            string startDate = Console.ReadLine();
                            Console.Write("Enter the end date (YYYYMMDD): ");
                            string endDate = Console.ReadLine();

                            for (int i = 0; i < amountOfData; i++)
                            {
                                if ((data[i].category == categ) &&
                                    (data[i].date.CompareTo(startDate) >= 0) &&
                                    (data[i].date.CompareTo(endDate) <= 0))
                                {
                                    Console.WriteLine("{0} - {1}/{2}/{3} - {4} -({5}) - {6}",
                                        i + 1,
                                        data[i].date.Substring(6, 2), // Day
                                        data[i].date.Substring(4, 2), // Month
                                        data[i].date.Substring(0, 4), // Year
                                        data[i].description,
                                        data[i].category,
                                        data[i].amount.ToString("N2"));
                                }
                            }
                        }
                        break;

                    case "3": //search
                        Console.Write("Enter part of the description or category: ");
                        string search = Console.ReadLine().ToUpper();
                        bool found = false;
                        for (int i = 0; i < amountOfData; i++)
                        {
                            if (data[i].description.ToUpper().Contains(search)
                                    || data[i].category.ToUpper().Contains(search))
                            {
                                Console.WriteLine("{0}: {1} - {2}",
                                    i + 1,
                                    data[i].date,
                                    data[i].description);
                                // TODO: Split in sixth space
                                found = true;
                            }
                        }
                        if (!found)
                            Console.WriteLine("Not found!");
                        break;

                    case "4":  // modify
                        Console.Write("Enter the record number: ");
                        int recNumber = Convert.ToInt32(Console.ReadLine()) - 1;

                        if ((recNumber > amountOfData) || (recNumber < 0))
                            Console.Write("Out of range!");
                        else
                        {
                            Console.Write("Date (was {0}; hit ENTER to leave as is): ",
                                data[recNumber].date);
                            string newText = Console.ReadLine();
                            if (newText != "")
                                data[recNumber].date = newText;

                            Console.Write("Description (was {0}; hit ENTER to leave as is): ",
                                data[recNumber].description);
                            newText = Console.ReadLine();
                            if (newText != "")
                                data[recNumber].description = newText;

                            Console.Write("Category (was {0}; hit ENTER to leave as is): ",
                                data[recNumber].category);
                            newText = Console.ReadLine();
                            if (newText != "")
                                data[recNumber].category = newText;

                            Console.Write("Amount (was {0}; hit ENTER to leave as is): ",
                                data[recNumber].amount);
                            newText = Console.ReadLine();
                            if (newText != "")
                                data[recNumber].amount = Convert.ToDouble(newText);
                        }
                        break;

                    case "5": //delete
                        int position = 0;
                        Console.Write("Enter the position number to delete: ");
                        position = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (position > amountOfData)
                            Console.WriteLine("Error: out of range");
                        else
                        {
                            // TODO: Ask for confirmation
                            for (int i = position; i < amountOfData; i++)
                                data[i] = data[i + 1];
                            amountOfData--;
                        }
                        break;

                    case "6": // Sort
                        accountData aux;
                        for (int i = 0; i < amountOfData - 1; i++)
                        {
                            for (int j = i + 1; j < amountOfData; j++)
                            {
                                string data1 = data[i].date + data[i].description;
                                string data2 = data[j].date + data[j].description;
                                if (data1.CompareTo(data2) > 0)
                                {
                                    aux = data[i];
                                    data[i] = data[j];
                                    data[j] = aux;
                                }
                            }
                        }
                        Console.WriteLine("Sorted.");
                        break;

                    case "7": //replace "  " x " "
                        for (int i = 0; i < amountOfData; i++)
                        {
                            data[i].description = data[i].description.Trim();
                            while (data[i].description.Contains("  "))
                                data[i].description = data[i].description.Replace("  ", " ");
                            if (data[i].description == data[i].description.ToUpper())
                                data[i].description = data[i].description.Substring(0, 1).ToUpper()
                                    + data[i].description.Substring(1).ToLower();
                        }
                        break;

                    case "T":
                    case "t":
                    case "Q":
                    case "q":
                        repeat = false;
                        break;

                    default:
                        Console.WriteLine("Wrong option!");
                        break;
                }
            } while (repeat != false);
            Console.WriteLine("Bye!");
        }
    }
}
