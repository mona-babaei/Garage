using System;
namespace GarageApp;

public class Airplane : Vehicle
{
    public int NumberOfEngines { get; set; } = 2;

   
    public override string ToString()
    {
        return base.ToString() + $", Engines: {NumberOfEngines}";
    }
}





