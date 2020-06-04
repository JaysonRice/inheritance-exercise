using System;
public class Tesla : Vehicle
{
    public double BatteryKWh { get; set; }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Tesla respectfully switches lanes! Vroom!");
    }
    public void ChargeBattery()
    {
        // method definition omitted
    }
}