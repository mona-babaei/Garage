using System;
namespace GarageApp
{
    public class AppMenu
    {
        private IHandler garage;
        private int garageCapacity;

        public AppMenu(IHandler garage, int garageCapacity)
        {
            this.garage = garage;
            this.garageCapacity = garageCapacity;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Add Vehicle");
                Console.WriteLine("2. Remove Vehicle");
                Console.WriteLine("3. Display All Vehicles");
                Console.WriteLine("4. Search By Registration Number");
                Console.WriteLine("5. Search By Properties");
                Console.WriteLine("6. Display Vehicle Count");
                Console.WriteLine("7. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddVehicle();
                        break;
                    case "2":
                        RemoveVehicle();
                        break;
                    case "3":
                        DisplayVehicles();
                        break;
                    case "4":
                        SearchByRegNumber();
                        break;
                    case "5":
                        SearchByProperties();
                        break;
                    case "6":
                        DisplayVehicleCount();
                        break;
                    case "7":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public void AddVehicle()
        {
            Console.WriteLine("Provide the vehicle registration number:");
            string regNum = Console.ReadLine().ToUpper();

            // ... Additional vehicle properties can be added as needed ...

            Vehicle newVehicle = new Vehicle { Registreringsnummer = regNum };
            if (garage.AddVehicle(newVehicle))
            {
                Console.WriteLine("Vehicle added successfully.");
            }
            else
            {
                Console.WriteLine("Failed to add vehicle.");
            }
        }

        public void RemoveVehicle()
        {
            Console.WriteLine("Enter the registration number of the vehicle to remove:");
            string regNum = Console.ReadLine().ToUpper();

            if (garage.RemoveVehicle(regNum))
            {
                Console.WriteLine($"Vehicle {regNum} removed successfully.");
            }
            else
            {
                Console.WriteLine($"Failed to remove vehicle {regNum}.");
            }
        }

        public void DisplayVehicles()
        {
            var vehicles = garage.GetVehicles();

            if (vehicles.Any())
            {
                foreach (var vehicle in vehicles)
                {
                    Console.WriteLine(vehicle.ToString());
                }
            }
            else
            {
                Console.WriteLine("No vehicles found.");
            }
        }

        public void SearchByRegNumber()
        {
            Console.WriteLine("Enter the registration number:");
            string regNum = Console.ReadLine().ToUpper();

            var vehicle = garage.GetVehicles().FirstOrDefault(v => v.Registreringsnummer.Equals(regNum, StringComparison.OrdinalIgnoreCase));
            if (vehicle != null)
            {
                Console.WriteLine(vehicle.ToString());
            }
            else
            {
                Console.WriteLine("Vehicle not found.");
            }
        }

        public void SearchByProperties()
        {
            Console.WriteLine("Enter vehicle color:");
            string color = Console.ReadLine();

            Console.WriteLine("Enter number of wheels:");
            int numberOfWheels;
            while (!int.TryParse(Console.ReadLine(), out numberOfWheels))
            {
                Console.WriteLine("Invalid input. Please enter a valid number for wheels.");
            }

            var vehicles = garage.GetVehicles().Where(v => v.Color.Equals(color, StringComparison.OrdinalIgnoreCase) && v.NumberOfWheels == numberOfWheels);
            if (vehicles.Any())
            {
                foreach (var vehicle in vehicles)
                {
                    Console.WriteLine(vehicle.ToString());
                }
            }
            else
            {
                Console.WriteLine("No vehicles found.");
            }
        }

        public void DisplayVehicleCount()
        {
            var count = garage.GetVehicles().Count();
            Console.WriteLine($"There are {count} vehicles in the garage.");
        }
    }

}

