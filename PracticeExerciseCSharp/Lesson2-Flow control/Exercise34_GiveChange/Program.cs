using System;

namespace Exercise34_GiveChange
{
    internal class Program
    {
        /// <summary>
        /// Create a C# program to return the change of a purchase, using coins (or bills) 
        /// as large as possible. Assume we have an unlimited amount of coins (or bills) 
        /// of 100, 50, 20, 10, 5, 2 and 1, and there are no decimal places. 
        /// Thus, the execution could be something like this: 
        /// 
        /// Price? 44
        /// Paid? 100
        /// Your change is 56: 50 5 1
        /// Price? 1
        /// Paid? 100
        /// Your change is 99: 50 20 20 5 2 2
        /// </summary>
        static void Main(string[] args)
        {
            int price, paid, change;

            Console.Write("Price? ");
            price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Paid? ");
            paid = Convert.ToInt32(Console.ReadLine());

            change = paid - price;
            Console.Write("Your change is {0}: ", change);
            while (change > 0)
            {
                if (change >= 50)
                {
                    Console.Write("50 ");
                    change -= 50;
                }
                else
                {
                    if (change >= 20)
                    {
                        Console.Write("20 ");
                        change -= 20;
                    }
                    else
                    {
                        if (change >= 10)
                        {
                            Console.Write("10 ");
                            change -= 10;
                        }
                        else
                        {
                            if (change >= 5)
                            {
                                Console.Write("5 ");
                                change -= 5;
                            }
                            else
                            {
                                if (change >= 2)
                                {
                                    Console.Write("2 ");
                                    change -= 2;
                                }
                                else
                                {
                                    Console.Write("1 ");
                                    change -= 1;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
