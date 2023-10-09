using System;
using System.Drawing;
namespace GarageApp
{




    internal class VehicleSearcher1<T> : IHandler where T : IVehicle
    {
        private Garage<T>? _garage;

        public VehicleSearcher1(Garage<T> garage)
        {
            _garage = garage;
        }

        public IVehicle? FindVehicleByRegNumber(string registreringsnummer)
        {
            return
                _garage.GetAllVehicles().FirstOrDefault(v => string.Equals(v?.Registreringsnummer?.ToLower(), registreringsnummer.ToLower());
        }

        public IEnumerable<T> FindVehiclesByProperties(string color, int numberOfWheels)
        {
            return
                _garage.GetAllVehicles().Where(v => (string.IsNullOrEmpty(color) || v.Color.ToLower() == color.ToLower())
                && (numberOfWheels == 0 || v.NumberOfWheels == numberOfWheels)).ToList();
        }

        public IEnumerable<T> FindVehicleByFuelType(string FuelType)
        {

            return
                _garage.GetAllVehicles().Where(V => V.FuelType.ToLower() == FuelType.ToLower()).ToList();
        }

        public IEnumerable<T> FindAllTaxis()
        {
            return
                _garage.GetAllVehicles().Where(v =>
                v.IsTaxi).ToList();





        }

        public bool AddVehicle(IVehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public bool RemoveVehicle(string registeringsnummer)
        {
            throw new NotImplementedException();
        }

        IEnumerable<IVehicle> IHandler.FindVehiclesByProperties(string color, int numberOfWheels)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IVehicle> GetVehicles()
        {
            throw new NotImplementedException();
        }

        public int DisplayVehicleCount()
        {
            throw new NotImplementedException();
        }

        public void FindvehicleByRegNumber()
        {
            throw new NotImplementedException();
        }

        void IHandler.VehicleSearcher1()
        {
            throw new NotImplementedException();
        }
    }

  
    
    
}








