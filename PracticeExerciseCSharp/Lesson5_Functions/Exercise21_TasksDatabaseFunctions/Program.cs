using System;

namespace Exercise21_TasksDatabaseFunctions
{
    /// <summary>
    /// Create an improved version of the "tasks database", splitting it into functions.
    /// </summary>
    internal class Program
    {
        struct DateType
        {
            public ushort year;
            public byte month;
            public byte day;
        }

        struct TaskType
        {
            public DateType date;
            public string description;
            public byte level;
            public string category;
        }

        static int counter = 0;
        static int capacity = 2000;
        static TaskType[] tasks = new TaskType[capacity];
        public static void Add()
        {
            if (counter < capacity)
            {
                Console.Write("Enter the Description of the task: ");
                tasks[counter].description = Console.ReadLine();

                Console.Write("Enter the Level of the task (1-10): ");
                tasks[counter].level = Convert.ToByte(Console.ReadLine());

                Console.Write("Enter the Category of the task: ");
                tasks[counter].category = Console.ReadLine();

                do
                {
                    Console.Write("Enter the Day of the task (1 to 31): ");
                    tasks[counter].date.day = Convert.ToByte(Console.ReadLine());
                    if (tasks[counter].date.day < 1 || tasks[counter].date.day > 31)
                        Console.WriteLine("Not a valid day!");
                }
                while (tasks[counter].date.day < 1 || tasks[counter].date.day > 31);

                do
                {
                    Console.Write("Enter the Month of the task (1 to 12): ");
                    tasks[counter].date.month = Convert.ToByte(Console.ReadLine());
                    if (tasks[counter].date.month < 1 || tasks[counter].date.month > 12)
                        Console.WriteLine("Not a valid month!");
                }
                while (tasks[counter].date.month < 1 || tasks[counter].date.month > 12);

                do
                {
                    Console.Write("Enter the Year of the task: ");
                    tasks[counter].date.year = Convert.ToUInt16(Console.ReadLine());
                    if (tasks[counter].date.year < 1000 || tasks[counter].date.year > 3000)
                        Console.WriteLine("Not a valid year!");
                }
                while (tasks[counter].date.year < 1000 || tasks[counter].date.year > 3000);
                counter++;
            }
            else
                Console.WriteLine("Database full.");
        }

        public static void Show()
        {
            if (counter >= 1)
            {
                byte startDay, startMonth;
                ushort startYear;
                byte endDay, endMonth;
                ushort endYear;

                Console.WriteLine("Starting day: ");
                string number = Console.ReadLine();

                if (number == "")
                    startDay = Convert.ToByte(DateTime.Now.Day);
                else
                    startDay = Convert.ToByte(number);

                Console.WriteLine("Starting month: ");
                number = Console.ReadLine();
                if (number == "")
                    startMonth = Convert.ToByte(DateTime.Now.Month);
                else
                    startMonth = Convert.ToByte(number);

                Console.WriteLine("Starting year: ");
                number = Console.ReadLine();
                if (number == "")
                    startYear = Convert.ToUInt16(DateTime.Now.Year);
                else
                    startYear = Convert.ToUInt16(number);

                Console.WriteLine("Final day: ");
                number = Console.ReadLine();
                if (number == "")
                    endDay = Convert.ToByte(DateTime.Now.Day);
                else
                    endDay = Convert.ToByte(number);

                Console.WriteLine("Final month: ");
                number = Console.ReadLine();
                if (number == "")
                    endMonth = Convert.ToByte(DateTime.Now.Month);
                else
                    endMonth = Convert.ToByte(number);

                Console.WriteLine("Final year: ");
                number = Console.ReadLine();
                if (number == "")
                    endYear = Convert.ToUInt16(DateTime.Now.Year);
                else
                    endYear = Convert.ToUInt16(number);

                string startDate = "" + startYear +
                    startMonth.ToString("00") + startDay.ToString("00");
                string endDate = "" + endYear +
                    endMonth.ToString("00") + endDay.ToString("00");

                for (int i = 0; i < counter; i++)
                {
                    string currentDate = "" + tasks[i].date.year +
                        tasks[i].date.month.ToString("00") + tasks[i].date.day.ToString("00");
                    if (currentDate.CompareTo(startDate) >= 0 && currentDate.CompareTo(endDate) <= 0)
                    {
                        Console.WriteLine("The number is {0}: {1}/{2}/" +
                            "{3} - {4} - {5} - {6}.", i + 1,
                            tasks[i].date.day, tasks[i].date.month,
                            tasks[i].date.year, tasks[i].description,
                            tasks[i].category, tasks[i].level);
                    }
                }
            }
            else
                Console.WriteLine("Database empty.");
        }

        public static void Find()
        {
            string search;
            bool found;
            if (counter >= 1)
            {
                Console.Write("Enter the text to search: ");
                search = Console.ReadLine();
                found = false;
                string newValue5;

                for (int i = 0; i < counter; i++)
                {
                    if (tasks[i].description.IndexOf(search) >= 0
                        || tasks[i].category.IndexOf(search) >= 0)
                    {
                        if (tasks[i].description.Length > 50)
                            newValue5 = tasks[i].description.Substring(0, 50);
                        else
                            newValue5 = tasks[i].description;

                        found = true;
                        Console.WriteLine("{0}: {1}/{2}/{3} - {4}",
                            i + 1, tasks[i].date.day, tasks[i].date.month,
                            tasks[i].date.year, newValue5);
                    }
                }
                if (!found)
                    Console.WriteLine("Not found.");
            }
            else
                Console.WriteLine("Database empty.");
        }

        public static void Update()
        {
            string newValue;
            if (counter >= 1)
            {
                Console.Write("Enter the number of the task to update: ");
                int update = Convert.ToInt32(Console.ReadLine()) - 1;
                if ((update >= 0) && (update < counter))
                {
                    Console.Write("Description ({0}): ",
                        tasks[update].description);
                    newValue = Console.ReadLine();
                    if (newValue != "")
                        tasks[update].description = newValue;

                    Console.WriteLine("Level ({0}): ",
                        tasks[update].level);
                    newValue = Console.ReadLine();
                    if (newValue != "")
                        tasks[update].level = Convert.ToByte(newValue);

                    Console.WriteLine("Category ({0}): ",
                        tasks[update].category);
                    newValue = Console.ReadLine();
                    if (newValue != "")
                        tasks[update].category = newValue;

                    Console.WriteLine("Year ({0}): ",
                        tasks[update].date.year);
                    newValue = Console.ReadLine();
                    if (newValue != "")
                        tasks[update].date.year = Convert.ToUInt16(newValue);

                    Console.WriteLine("Month ({0}): ",
                        tasks[update].date.month);
                    newValue = Console.ReadLine();
                    if (newValue != "")
                        tasks[update].date.month = Convert.ToByte(newValue);

                    Console.WriteLine("Day ({0}): ",
                        tasks[update].date.day);
                    newValue = Console.ReadLine();
                    if (newValue != "")
                        tasks[update - 1].date.day = Convert.ToByte(newValue);
                }
                else
                    Console.WriteLine("Wrong number entered.");
            }
            else
                Console.WriteLine("Database empty.");
        }

        public static void Delete()
        {
            if (counter >= 1)
            {
                Console.Write("Enter the first number of data to delete: ");
                int delete = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write("Enter the second number of data to delete: ");
                int delete2 = Convert.ToInt32(Console.ReadLine()) - 1;

                for (int pos = delete; pos <= delete2; pos++)
                {
                    for (int i = delete2; i < counter; i++)
                        tasks[i] = tasks[i + 1];
                    counter--;
                }
            }
            else
                Console.WriteLine("Database empty.");
        }

        public static void Sort()
        {
            for (int i = 0; i < counter - 1; i++)
            {
                string firstDate = "" + tasks[i].date.year +
                    tasks[i].date.month.ToString("00") +
                    tasks[i].date.day.ToString("00") +
                    tasks[i].description;
                for (int j = i + 1; j < counter; j++)
                {
                    string secondDate = "" + tasks[j].date.year +
                        tasks[j].date.month.ToString("00") +
                        tasks[j].date.day.ToString("00") +
                        tasks[j].description;

                    if (firstDate.CompareTo(secondDate) > 0)
                    {
                        TaskType aux = tasks[i];
                        tasks[i] = tasks[j];
                        tasks[j] = aux;
                    }
                }
            }
        }

        public static void FindDuplicates()
        {
            for (int i = 0; i < counter - 1; i++)
            {
                for (int j = i + 1; j < counter; j++)
                {
                    if (tasks[i].description == tasks[j].description)
                    {
                        Console.WriteLine("{0} - {1}/{2}/{3}",
                            tasks[i].description, tasks[i].date.day,
                            tasks[i].date.month, tasks[i].date.year);
                        Console.WriteLine("{0} - {1}/{2}/{3}",
                            tasks[j].description, tasks[j].date.day,
                            tasks[j].date.month, tasks[j].date.year);
                    }
                }
            }
        }

        public static void Main()
        {
            char option;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Tasks database");
                Console.WriteLine();
                Console.WriteLine("1- Add a new task.");
                Console.WriteLine("2- Show the tasks between two certain dates.");
                Console.WriteLine("3- Find tasks that contain a certain text.");
                Console.WriteLine("4- Update a record.");
                Console.WriteLine("5- Delete some data, between two positions indicated.");
                Console.WriteLine("6- Sort the data alphabetically by date.");
                Console.WriteLine("7- Find Duplicates.");
                Console.WriteLine("Q- Quit.");
                Console.WriteLine("Enter an option:");
                option = Convert.ToChar(Console.ReadLine().ToUpper());

                switch (option)
                {
                    case '1': //Add a new task
                        Add();
                        break;

                    case '2': //Show the tasks between two certain dates
                        Show();
                        break;

                    case '3': //Find tasks that contain a certain text
                        Find();
                        break;

                    case '4': //Update a record
                        Update();
                        break;

                    case '5': //Delete some data, between two positions indicated by the user
                        Delete();
                        break;

                    case '6': //Sort the data alphabetically on date + description
                        Sort();
                        break;

                    case '7': //Find Duplicates
                        FindDuplicates();
                        break;

                    case 'Q': //Quit
                        Console.WriteLine("Quitting...");
                        break;

                    default:
                        Console.WriteLine("You entered a wrong option. Please re-enter it.");
                        break;
                }
            }
            while (option != 'Q');
        }
    }
}
