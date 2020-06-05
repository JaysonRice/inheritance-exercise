using System;
public class Cessna : Vehicle
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        // method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Cessna flies by! Zoooooom!");
    }
    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Cessna does a barrel roll maneuver.");
    }
    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Cessna lands at the airport!");
    }
}