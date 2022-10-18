using System;

namespace Exercise19_SeveralMutiplicationTables
{
    internal class Program
    {
        /// <summary>
        /// Display the multiplication tables from 2 to 6, using nested "do...while" statements.
        /// </summary>
        static void Main(string[] args)
        {
            int num, multiplier;

            num = 2;

            do
            {

                multiplier = 1;
                do
                {
                    Console.WriteLine("{0} x {1} = {2}",
                        num, multiplier, num * multiplier);
                    multiplier++;
                }
                while (multiplier <= 10);

                Console.WriteLine();
                num++;

            } while (num <= 6);
        }
    }
}
