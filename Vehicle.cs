using System;
public class Vehicle
{
    public virtual string MainColor { get; set; }
    public virtual string MaximumOccupancy { get; set; }

    public virtual void Drive()
    {
        Console.WriteLine("Vrooom!");
    }
    public virtual void Turn()
    {
        Console.WriteLine("The vehicle signals before making a right turn.");
    }
    public virtual void Stop()
    {
        Console.WriteLine("The vehicle slows to a stop.");
    }
}