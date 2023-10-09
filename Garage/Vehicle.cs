namespace GarageApp;

public class Vehicle : IVehicle
{
    public virtual string? Registreringsnummer { get; set; }
    public string? Color { get; set; }
    public int NumberOfWheels { get; set; }

    public string FuelType { get; set; }
    public bool IsTaxi { get; set; }
    public virtual void Start()
    {


        Console.WriteLine("Vehicle started.");

    }

    public virtual void Stop()
    {
        Console.WriteLine("Vehicle started.");


    }
}

/* uniq nummer per vehicle t.ex registeringnummer  */

