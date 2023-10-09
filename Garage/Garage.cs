namespace GarageApp
{

    public class Garage<T>  where T : IVehicle
    {

        private T[] vehiclesArray;
        public Garage (int capacity)

        {
            vehiclesArray = new T[capacity];
        }

        public bool AddVehicle(T vehicle)
        {
            for (int i = 0; i < vehiclesArray.Length; i++)
            {
                if (vehiclesArray[i] == null)
                {
                    vehiclesArray[i] = vehicle;
                    Console.WriteLine($"vehicle{vehicle.Registreringsnummer} has been parked.");
                    return true;
                }
            }
            Console.WriteLine("The garage is full.Cannot park the vehicle.");
            return false; // garage is full.
        }

        public bool RemoveVehicle(string registreringsnummer)
        {
            for (int i = 0; i < vehiclesArray.Length; i++)
            {
                if (vehiclesArray[i]?.Registreringsnummer == registreringsnummer)
                {
                    vehiclesArray[i] = default(T);
                    Console.WriteLine($"vehicle {registreringsnummer} has been removed from the garage.");
                    return true;
                }
            }
            Console.WriteLine($"vehicle with regisration number {registreringsnummer}not found.");
            return false; // vehicle not found.
        }

        public IEnumerable<T> GetAllVehicles()
        {

            return vehiclesArray.Where(vehicle => vehicle != null);
        }
        public void DisplayVehicleCount()

        {
            var count =
                vehiclesArray.Count(Vehicle != null);
            Console.WriteLine($"There are {count} vehicle in the garage.");
        }
            
        public IEnumerable<IVehicle>GetVehicles()
        {

            return
                 vehiclesArray.OfType<IVehicle>();


            

        }
    }
}

       

        
            
        

        
        
    







                  
            
         