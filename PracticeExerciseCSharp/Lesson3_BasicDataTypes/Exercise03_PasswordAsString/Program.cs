using System;

namespace Exercise03_PasswordAsString
{
    internal class Program
    {
        /// <summary>
        /// Write a program to ask the user for his/her name and his/her password (both must be strings) 
        /// and repeat it as many times as necessary, until the entered name is "user" 
        /// and the password is "password".
        /// </summary>
        static void Main(string[] args)
        {
            string user, password;

            do
            {
                Console.Write("Enter a user: ");
                user = Console.ReadLine();

                Console.Write("Enter a password: ");
                password = Console.ReadLine();
            }
            while (user != "user" && password != "password");
            Console.WriteLine("Bye!");
        }
    }
}
