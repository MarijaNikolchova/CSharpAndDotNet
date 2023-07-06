/*using Azure;
using Microsoft.Data.SqlClient;
using System.IO;
using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using System.Web;

using System;
using System.Data.SqlClient;

namespace ExampleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connection string for Windows Authentication
            string connectionString = "Server=DESKTOP-MOOICF1;Database=Reading;Trusted_Connection=True;";

            // Query to insert data into database
            string query = "INSERT INTO MyTable (Title, Body) VALUES (@Title, @Body)";

            // Prompt user for title and body
            Console.Write("Enter title: ");
            string title = Console.ReadLine();
            Console.Write("Enter body: ");
            string body = Console.ReadLine();

            try
            {
                // Create and open database connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Create SQL command with parameterized query
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Body", body);

                        // Execute SQL command
                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine("{0} rows affected.", rowsAffected);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: {0}", ex.Message);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}*/