namespace GarageApp
{

    public class Vehicle : IVehicle
    {
       

        public string? Registreringsnummer { get; set; }
        public string Color { get; set; }
        public int NumberOfWheels { get; set; }

       

        public override string ToString()
        {
            return $"RegNO: {Registreringsnummer},Color {Color}, Wheels: {NumberOfWheels}";
        }
    }
}




