using Azure;
using Microsoft.Data.SqlClient;
using MyProject;
using Newtonsoft.Json;
using System.Net.Mail;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Microsoft.Data.SqlClient;


namespace ProjectVs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            string error = ValidateLoginForm(username, password);
            if (!string.IsNullOrEmpty(error))
            {
                Console.WriteLine(error);
                return;
            }

            Users user = GetUserByUsername(username);
            if (user == null || !user.Password.Equals(password))
            {
                Console.WriteLine("Invalid username or password.");
                return;
            }

            Console.WriteLine("Login successful!");

            // Wait for 5 seconds
            System.Threading.Thread.Sleep(5000);

            Console.WriteLine("Redirecting to index.html...");

            Console.ReadLine();
        }

        private static string ValidateLoginForm(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return "Username and password are required.";
            }

            return null;
        }

        private static Users GetUserByUsername(string username)
        {
            string connectionString = "Data Source=DESKTOP-MOOICF1;Initial Catalog=Register;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM dbo.users WHERE username = @username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Users user = new Users
                            {
                                Id = reader.GetInt32(0),
                                Username = reader.GetString(1),
                                Email = reader.GetString(2),
                                Password = reader.GetString(3)
                            };

                            return user;
                        }
                    }
                }
            }

            return null;
        }
    }

    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}



