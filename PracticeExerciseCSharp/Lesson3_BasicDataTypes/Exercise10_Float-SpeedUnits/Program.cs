using System;

namespace Exercise10_Float_SpeedUnits
{
    internal class Program
    {
        /// <summary>
        /// Create a program to ask the user for a distance (in meters) and the time taken 
        /// (as three numbers: hours, minutes, seconds), and display the speed, in meters per second, 
        /// kilometers per hour and miles per hour (hint: 1 mile = 1609 meters).
        /// </summary>
        static void Main(string[] args)
        {
            float distance;
            float hour, min, sec;

            float timeSec;
            float mps;
            float kph, mph;

            Console.Write("Enter distance(meters): ");
            distance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter timeSec(hour): ");
            hour = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter timeSec(minutes): ");
            min = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter timeSec(seconds): ");
            sec = Convert.ToSingle(Console.ReadLine());

            timeSec = (hour * 3600) + (min * 60) + sec;
            mps = distance / timeSec;
            kph = (distance / 1000.0f) / (timeSec / 3600.0f);
            mph = kph / 1.609f;

            Console.WriteLine("Your speed in meters/sec is {0}", mps);
            Console.WriteLine("Your speed in km/h is {0}", kph);
            Console.WriteLine("Your speed in miles/h is {0}", mph);
        }
    }
}
