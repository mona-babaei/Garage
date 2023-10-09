using System;
namespace GarageApp
{
   public  interface IVehicle
    {    
       
             string? Registreringsnummer { get; set; }
             string? Color { get; set; }
            int NumberOfWheels { get; set; }

            string FuelType { get; set; }
            bool IsTaxi { get; set; }
        void Start();
            void Stop();
        

    }

}

