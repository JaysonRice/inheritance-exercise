using System;

namespace inheritance_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Tesla JaysonsCar = new Tesla()
            {
                MainColor = "Black",
                MaximumOccupancy = "4",
                BatteryKWh = 2.2
            };

            Cessna JaysonsCessna = new Cessna()
            {
                MainColor = "Eggshell",
                MaximumOccupancy = "8",
                FuelCapacity = 42.5
            };

            Ram JaysonsTruck = new Ram()
            {
                MainColor = "Cobalt Blue",
                MaximumOccupancy = "6",
                FuelCapacity = 31.5
            };
            JaysonsCar.Drive();
            JaysonsCessna.Drive();
            JaysonsTruck.Drive();


        }
    }
}
