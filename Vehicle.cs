using System;
public class Vehicle
{
    public virtual string MainColor { get; set; }
    public virtual string MaximumOccupancy { get; set; }

    public virtual void Drive()
    {
        Console.WriteLine("Vrooom!");
    }
}