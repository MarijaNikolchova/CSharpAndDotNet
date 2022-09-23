using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Car : IVehicle
    {
        public int carTank { get; set; }

        public Car()
        {
            carTank = 0;
        }
        public void Drive()
        {
            if (carTank < 1)
            {
                Console.WriteLine("Not Driving ");
            }
            else
            {
                Console.WriteLine("Driving");
            }
        }

        public bool Refuel(int liters)
        {
            carTank += liters;
            return true;
        }
    }
}
