using System;

namespace Exercise17_Password2
{
    internal class Program
    {
        /// <summary>
        /// Write a program to ask the user for his/her login and his/her password 
        /// (both must be integer numbers), until the entered login is "12" and the password is "1234". 
        /// The user will have 3 attempts maximum.
        /// </summary>
        static void Main(string[] args)
        {
            int user, pass;
            int counter = 0;

            do
            {
                Console.Write("Enter a user:  ");
                user = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter a password:  ");
                pass = Convert.ToInt32(Console.ReadLine());

                if ((user != 12) || (pass != 1234))
                {
                    Console.WriteLine("Login Error");
                    counter++;
                }

            }
            while (((user != 12) || (pass != 1234)) && (counter != 3));

            if ((user != 12) || (pass != 1234))
                Console.WriteLine("Logged out!");
            else
                Console.WriteLine("Login successful");
        }
    }
}
