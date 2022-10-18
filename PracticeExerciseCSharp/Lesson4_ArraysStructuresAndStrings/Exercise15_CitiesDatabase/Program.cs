using System;

namespace Exercise15_CitiesDatabase
{
    /// <summary>
    /// Create a database to store information about cities.
    /// 
    /// In a first approach, we will store only the name of each city and the number of inhabitants, 
    /// and allocate space for up to 500 cities.
    /// 
    /// The menu should include the following options:
    /// 1 .- Add a new city(at the end of the existing data)
    /// 2 .- View all cities(name and inhabitants)
    /// 3 .- Modify a record(rename and / or change number of inhabitants)
    /// 4 .- Insert a new record(in a specified position, moving the following ones ton the right)
    /// 5 .- Delete a record(moving the following ones to the left so that no empty spaces are left)
    /// 6 .- Search in the records(display the ones which contain a certain text in their name, 
    /// whether in upper or lower case, using partial search)
    /// 7 .- Correct the capitalization of the names(turn into uppercase the first letter and the 
    /// ones after a space, and make the rest lowercase).
    /// 0 .- Exit
    /// </summary>
    internal class Program
    {
        struct city
        {
            public string name;
            public uint inhabitants;
        }
        static void Main(string[] args)
        {
            int maxCities = 500;
            city[] cities = new city[maxCities];
            int amount = 0;
            int currentCityNumber;
            string option;
            string textToSearch;
            bool found;
            string textToModify;
            bool finished = false;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Cities database");
                Console.WriteLine();
                Console.WriteLine("1.- Add a new city");
                Console.WriteLine("2.- View all cities");
                Console.WriteLine("3.- Modify a record");
                Console.WriteLine("4.- Insert a new record");
                Console.WriteLine("5.- Delete a record");
                Console.WriteLine("6.- Search in the records");
                Console.WriteLine("7.- Correct the capitalization of the names");
                Console.WriteLine("0.- Exit");
                Console.WriteLine();
                Console.Write("Choose an option: ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "0":
                        finished = true;
                        break;

                    case "1":
                        if (amount > maxCities - 1)
                            Console.WriteLine("the database is full");
                        else
                        {
                            Console.WriteLine("Entering data for city number {0}", amount + 1);
                            Console.Write("Enter the city name: ");
                            cities[amount].name = Console.ReadLine();
                            Console.Write("Enter the inhabitants numbers: ");
                            cities[amount].inhabitants = Convert.ToUInt32(Console.ReadLine());
                            Console.WriteLine("The data was entered correctly");
                            amount++;
                        }
                        break;

                    case "2":
                        for (int i = 0; i < amount; i++)
                        {
                            Console.WriteLine("{0}: {1}, {2} inhabitants",
                            i + 1, cities[i].name, cities[i].inhabitants);
                        }
                        Console.WriteLine();
                        break;

                    case "3":
                        Console.Write("Enter the city number: ");
                        currentCityNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter a new data for a city number: {0}", currentCityNumber);
                        Console.Write("City name (was {0}; hit ENTER to leave as is): ", cities[currentCityNumber - 1].name);
                        textToModify = Console.ReadLine();
                        if (textToModify != "")
                            cities[currentCityNumber - 1].name = textToModify;
                        Console.Write("Inhabitants (was {0}; hit ENTER to leave as is): ",
                        cities[currentCityNumber - 1].inhabitants);
                        textToModify = Console.ReadLine();
                        if (textToModify != "")
                            cities[currentCityNumber - 1].inhabitants = Convert.ToUInt32(textToModify);
                        Console.WriteLine();
                        break;
                    case "4":
                        if (amount > maxCities - 1)
                            Console.WriteLine("The database is full");
                        else
                        {
                            Console.Write("Enter the number of the city to modify: ");
                            currentCityNumber = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Insert a new data at {0} position: ", currentCityNumber);
                            amount++;
                            for (int i = (int)amount; i > currentCityNumber - 1; i--)
                            {
                                cities[i] = cities[i - 1];
                            }
                            Console.Write("City name: ");
                            cities[currentCityNumber - 1].name = Console.ReadLine();
                            Console.Write("Inhabitants: ");
                            cities[currentCityNumber - 1].inhabitants = Convert.ToUInt32(Console.ReadLine());
                        }
                        break;

                    case "5":
                        Console.Write("Enter the city number for delete: ");
                        currentCityNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Deleting the number {0}", currentCityNumber);
                        for (int i = currentCityNumber - 1; i < amount; i++)
                        {
                            cities[i] = cities[i + 1];
                        }
                        amount--;
                        break;

                    case "6":
                        Console.Write("Enter the text to search: ");
                        textToSearch = Console.ReadLine();
                        found = false;
                        for (int i = 0; i < amount; i++)
                        {
                            if (cities[i].name.ToUpper().IndexOf(textToSearch.ToUpper()) >= 0)
                            {
                                Console.WriteLine("{0} found in {1}",
                                textToSearch, cities[i].name);
                                found = true;
                            }
                        }
                        if (!found)
                            Console.WriteLine("Not found.");
                        break;

                    case "7":
                        for (int i = 0; i < amount; i++)
                        {
                            string lowerCaseName = cities[i].name.ToLower();
                            string correctedName = lowerCaseName.Substring(0, 1).ToUpper()
                            + lowerCaseName.Substring(1);
                            for (int j = 1; j < correctedName.Length - 2; j++)
                            {
                                if (correctedName[j] == ' ')
                                    correctedName = correctedName.Substring(0, j) + " " +
                                    correctedName.Substring(j + 1, 1).ToUpper() +
                                    correctedName.Substring(j + 2);
                            }
                            cities[i].name = correctedName;
                        }
                        break;

                    default:
                        Console.WriteLine("Wrong option ");
                        break;

                }

            }
            while (!finished);
        }
    }
}
