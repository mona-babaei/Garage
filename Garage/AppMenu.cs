using System;
namespace GarageApp
{
    public class AppMenu
    {
        private IHandler handlder;
        private int garageCapacity;


        public void Run()
        {
            bool success = false;
            do
            {

                Console.WriteLine("Enter capacity for garage");

                if (int.TryParse(Console.ReadLine()!, out int capacity))
                {
                    this.handlder = new GarageHandler(capacity);
                    garageCapacity = capacity;
                    success = true;

                }

            } while (!success);



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

            //Men choose wich type of vehicle?
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Bus");

            var input = Console.ReadLine()!;
            IVehicle vehicle = default!;

            switch (input)
            {
                case "1":
                    var carProps = GetCommonVehicleValues();
                    //Ask for specif property for car: IsSport
                    vehicle = new Car()
                    {
                        Color = carProps.Color,
                        Registreringsnummer = carProps.Registreringsnummer,
                        IsSport = true,
                        NumberOfWheels = carProps.NumberOfWheels,
                    };



                    break;
                case "2":
                    var busProps = GetCommonVehicleValues();
                    //Ask for specifik bus values
                    //Create bus instance
                    

                    break; 
                
                case "3":
                    var airplaneProps = GetCommonVehicleValues();

                    break;

                default:
                    Console.WriteLine("Wrong input...");
                    break;
            }

            if (handlder.AddVehicle(vehicle))
            {
                Console.WriteLine("Vehicle added successfully.");
            }
            else
            {
                Console.WriteLine("Failed to add vehicle.");
            }
        }

        private VehicleDTO GetCommonVehicleValues()
        {
            var vehicleDTO = new VehicleDTO();
            bool success = false;
            do
            {

                Console.WriteLine("Provide the vehicle registration number:");
                var regNo = Console.ReadLine().ToUpper();
                var found = handlder.FindVehicleByRegNumber(regNo);

                if (found != null)
                {
                    Console.WriteLine("${regNo} alaready is in garage");
                }
                else
                {
                    vehicleDTO.Registreringsnummer = regNo;
                    success = true;
                }

            } while (!success);


           Console.WriteLine("Provide the color:");
            string color = Console.ReadLine();

            //Validate color not empty
            vehicleDTO.Color = color;
            //Ask for rest of the propertys


            return vehicleDTO;
        }

        public void RemoveVehicle()
        {
            Console.WriteLine("Enter the registration number of the vehicle to remove:");
            string regNum = Console.ReadLine().ToUpper();

            if (handlder.RemoveVehicle(regNum))
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
            var vehicles = handlder.GetVehicles();

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

            var vehicle = handlder.GetVehicles().FirstOrDefault(v => v.Registreringsnummer.Equals(regNum, StringComparison.OrdinalIgnoreCase));
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

            var vehicles = handlder.GetVehicles().Where(v => v.Color.Equals(color, StringComparison.OrdinalIgnoreCase) && v.NumberOfWheels == numberOfWheels);
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
            var count = handlder.GetVehicles().Count();
            Console.WriteLine($"There are {count} vehicles in the garage.");
        }
    }

}

