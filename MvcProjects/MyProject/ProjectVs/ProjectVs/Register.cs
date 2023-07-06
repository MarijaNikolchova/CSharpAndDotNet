/*using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Net.Mail;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace MyProject
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public static class Registration
    {
        private static readonly string FilePath = "users.json";

        public static string SaveUser(User user)
        {
            string error = "";

            
            if (string.IsNullOrEmpty(user.Username))
            {
                error += "Username is required.\n";
            }

            
            if (string.IsNullOrEmpty(user.Email) || !IsValidEmail(user.Email))
            {
                error += "Email is invalid.\n";
            }

            
            if (string.IsNullOrEmpty(user.Password) || user.Password.Length < 8)
            {
                error += "Password must be at least 8 characters.\n";
            }

           
            if (!string.IsNullOrEmpty(error))
            {
                throw new Exception(error);
            }

           
            if (UserExists(user.Username, user.Email))
            {
                throw new Exception("User already exists.");
            }

            
            List<User> users = GetAllUsers();

            
            users.Add(user);

            
            SaveAllUsers(users);

            return null;
        }

        
        private static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

       
        public static bool UserExists(string username, string email)
        {
            List<User> users = GetAllUsers();
            foreach (User user in users)
            {
                if (user.Username == username || user.Email == email)
                {
                    return true;
                }
            }
            return false;
        }

        
        public static List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                users = JsonConvert.DeserializeObject<List<User>>(json);
            }
            return users;
        }

        
        public static void SaveAllUsers(List<User> users)
        {
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }
    }

    public static class Login
    {
        
        public static bool IsValidUser(string username, string password)
        {
            List<User> users = Registration.GetAllUsers();
            foreach (User user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}*/