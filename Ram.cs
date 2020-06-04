using System;
public class Ram : Vehicle
{
    public double FuelCapacity { get; set; }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Ram wastes a lot of gas! Babroooom!");
    }
    public void RefuelTank()
    {
        // method definition omitted
    }
}