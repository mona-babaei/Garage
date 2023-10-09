
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace GarageApp
{

    class Program 
    {
        static void Main(string[] args)
        {
            Garage<IVehicle> garage = new
                Garage<IVehicle>(6);
        

            for (int i = 0; i < 6; i++)
            {
                garage.AddVehicle(new Car { Registreringsnummer = $"ABC{123+i}" });
                garage.AddVehicle(new Bus { Registreringsnummer = $"ABC{124+i}" });
                garage.AddVehicle(new Motorcycle { Registreringsnummer = $"ABC-Motorcycle{125+i}" });
                garage.AddVehicle(new Airplane { Registreringsnummer = $"ABC-Airplane{126+i}" });
                garage.AddVehicle(new Boat { Registreringsnummer = $"ABC{127+i}" });
            }

            VehicleSearcher<IVehicle> vehicleSearcher = new VehicleSearcher<IVehicle>(garage);
            AppMenu ui = new AppMenu ((IHandler)vehicleSearcher, 30);
            ui.Run();
        }

    }

    internal class VehicleSearcher<T>  where T :IVehicle
    {
        
        private Garage<T> _garage;

        public VehicleSearcher(Garage<T> garage)
        {
            _garage = garage;
        }

        
    }
}
