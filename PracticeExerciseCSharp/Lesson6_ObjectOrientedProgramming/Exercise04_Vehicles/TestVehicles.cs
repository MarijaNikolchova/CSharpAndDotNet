using System;

namespace Exercise04_Vehicles
{
    /// <summary>
    /// Using Visual Studio, create a project and the corresponding classes (using several files) 
    /// for this classes diagram. Each class must include the attributes and methods shown in the diagram, 
    /// as well as Get and Set methods for Vehicle and "Has" methods ("HasDualSlidingDoors") for MiniVan.
    ///
    /// You must create also a test program, which will create an object belonging to each class and tell it to "Drive".
    /// </summary>
    internal class TestVehicles
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Drive();

            Sportscar mySportsCar = new Sportscar();
            mySportsCar.Drive();

            Van myVan = new Van();
            myVan.Drive();

            Minivan myMiniVan = new Minivan();
            myMiniVan.Drive();

            ExcursionVan myExcursionVan = new ExcursionVan();
            myExcursionVan.Drive();
        }
    }
}
