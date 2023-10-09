using System;
namespace GarageApp;

public class Bus :Vehicle
{
	public int NumberOfSeats { get; set; } = 33;

    public override string? Registreringsnummer { get; set; }
    public static new void Start()
    {
        Console.WriteLine("Bus started.");
    }

    public  override void Stop()
    {
        Console.WriteLine("Bus stopped.");
    }
}




