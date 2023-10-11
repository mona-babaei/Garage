using System;
namespace GarageApp;

public class Airplane : Vehicle
{
    public int NumberOfEngines { get; set; } = 2;

    public   string? Registreringsnummer { get; set; }
    public override void Start()
    {
        Console.WriteLine("Airplane started.");
    }

    public override void Stop()
    {
        Console.WriteLine("Airplane stopped.");
    }
    public override string ToString()
    {
        return base.ToString() + $", Engines: {NumberOfEngines}";
    }
}





