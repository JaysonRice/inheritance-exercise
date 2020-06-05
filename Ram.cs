using System;
public class Ram : Vehicle
{
    public double FuelCapacity { get; set; }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Ram wastes a lot of gas! Babroooom!");
    }
    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Ram makes a very wide left turn.");
    }
    public void RefuelTank()
    {
        // method definition omitted
    }
}