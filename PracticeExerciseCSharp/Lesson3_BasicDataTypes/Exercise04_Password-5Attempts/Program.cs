using System;

namespace Exercise04_Password_5Attempts
{
    internal class Program
    {
        /// <summary>
        /// Write a program which asks the user for his login and password. Both must be strings. 
        /// After 5 wrong attempts, the user will be rejected.
        /// </summary>
        static void Main(string[] args)
        {
            string user, pass;
            int count = 0;

            do
            {
                Console.Write("Enter username: ");
                user = Console.ReadLine();

                Console.Write("Enter password: ");
                pass = Console.ReadLine();

                count++;

            }
            while (((user != "user") || (pass != "password"))
                && (count != 5));

            if (count == 5)
                Console.Write("Login attemp fail!");
            else
                Console.Write("Password correct!");
        }
    }
}
