using System;
using System.Collections.Generic;

namespace inheritance_practice
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Vehicle> allVehicles = new List<Vehicle>();

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

            allVehicles.Add(JaysonsCar);
            allVehicles.Add(JaysonsCessna);
            allVehicles.Add(JaysonsTruck);

            foreach (Vehicle singleVehicle in allVehicles)
            {
                singleVehicle.Drive();
                singleVehicle.Turn();
                singleVehicle.Stop();
                Console.WriteLine();
            }
        }
    }
}
