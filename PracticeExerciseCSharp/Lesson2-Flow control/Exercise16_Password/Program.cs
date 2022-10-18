using System;

namespace Exercise16_Password
{
    internal class Program
    {
        /// <summary>
        /// Write a program to ask the user for his/her login and his/her password (both must be integer numbers) and repeat it as many times as necessary, 
        /// until the entered login is "12" and the password is "1234".
        /// </summary>
        static void Main(string[] args)
        {
            int user, pass;

            do
            {
                Console.Write("Enter a user:  ");
                user = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter a password:  ");
                pass = Convert.ToInt32(Console.ReadLine());

                if ((user != 12) || (pass != 1234))
                    Console.WriteLine("Login Error");

            }
            while ((user != 12) || (pass != 1234));

            Console.WriteLine("Login successful");
        }
    }
}
