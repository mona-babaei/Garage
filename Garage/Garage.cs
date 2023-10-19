using System.Collections;
using System.Collections.Generic;


namespace GarageApp
{
    public class Garage<T> : IEnumerable<T> where T : IVehicle
    {
        private T[] vehiclesArray;
        public int Count { get; private set; } = 0;

        public Garage(int capacity)
        {
            vehiclesArray = new T[capacity];
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var vehicle in vehiclesArray)
            {
                if (vehicle != null)
                    yield return vehicle;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool AddVehicle(T vehicle)
        {
            for (int i = 0; i < vehiclesArray.Length; i++)
            {
                if (vehiclesArray[i] == null)
                {
                    vehiclesArray[i] = vehicle;
                   // Console.WriteLine($"Vehicle {vehicle.Registreringsnummer} has been parked.");
                   Count++;
                    return true;
                }
            }
            Console.WriteLine("The garage is full. Cannot park the vehicle.");
            return false;
        }

        public bool RemoveVehicle(string registreringsnummer)
        {
            for (int i = 0; i < vehiclesArray.Length; i++)
            {
                if (vehiclesArray[i]?.Registreringsnummer == registreringsnummer)
                {
                    vehiclesArray[i] = default(T);
                    Console.WriteLine($"Vehicle {registreringsnummer} has been removed from the garage.");
                    Count--;
                    return true;
                }
            }
            Console.WriteLine($"Vehicle with registration number {registreringsnummer} not found.");
            return false;
        }

        //public IEnumerable<T> GetAllVehicles()
        //{
        //    return vehiclesArray.Where(vehicle => vehicle != null);
        //}

        public void DisplayVehicleCount()
        {
           // var count = vehiclesArray.Count(vehicle => vehicle != null);
            Console.WriteLine($"There are {Count} vehicles in the garage.");
        }

        //public IEnumerable<IVehicle> GetVehicles()
        //{
        //    return vehiclesArray.OfType<IVehicle>();
        //}
    }

}
