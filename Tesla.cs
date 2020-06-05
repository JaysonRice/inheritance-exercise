using System;
public class Tesla : Vehicle
{
    public double BatteryKWh { get; set; }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Tesla respectfully switches lanes! Vroom!");
    }

    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Tesla stops in a designated charging spot.");
    }
    public void ChargeBattery()
    {
        // method definition omitted
    }
}