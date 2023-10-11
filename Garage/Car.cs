using System;
namespace GarageApp
{

    public class Car : Vehicle
    {


        public bool IsSport { get; set; }
        public bool IsCargoVehicle { get; set; }
       /* public  string ToString()
        {
            return $"Car - Registration Number: {Registreringsnummer}, Color: {Color}, Number of Wheels: {NumberOfWheels}";
        }*/

        public override void Start()
        {
            Console.WriteLine("Car started.");
        }

        public override void Stop()
        {
            Console.WriteLine("Car stopped.");

        }

        public override string ToString()
        {
            return base.ToString() + $", Fuel: {FuelType}, Taxi: {IsTaxi}";
        }

    }
}





   



