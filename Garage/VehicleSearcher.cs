using System;
using System.Drawing;
using System.Collections.Generic;
namespace GarageApp
{
    internal class GarageHandler : IHandler
    {
        private Garage<IVehicle> _garage;
        private object vehicle;

        public GarageHandler(int capacity)
        {
            _garage = new Garage<IVehicle>(capacity);
        }

        public bool AddVehicle(IVehicle vehicle)
        {
            return _garage.AddVehicle(vehicle);
        }

        public bool RemoveVehicle(string registeringsnummer)
        {
            return _garage.RemoveVehicle(registeringsnummer);
        }

        public IVehicle FindVehicleByRegNumber(string registeringsnummer)
        {
            return _garage.GetAllVehicles().FirstOrDefault(vehicle => vehicle.Registreringsummer == registeringsnummer);
        }

        public IEnumerable<IVehicle> FindVehiclesByProperties(string color, int numberOfWheels)
        {
            return _garage.GetAllVehicles()
                          .Where(vehicle => vehicle.Color.ToLower() == color.ToLower() && vehicle.NumberOfWheels == numberOfWheels)
                          .ToList();
        }

        public IEnumerable<IVehicle> GetVehicles()
        {
            return _garage.GetVehicles();
        }

        public int DisplayVehicleCount()
        {
            return _garage.GetAllVehicles().Count();
        }

    }
}
    
