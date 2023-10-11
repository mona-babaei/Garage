
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace GarageApp
{

    class Program 
    {
        private static object value;

        static void Main(string[] args, object value)
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

           // Garage<IVehicle> garage = new
            Garage<IVehicle>(30);
            
            AppMenu ui = new AppMenu (garageHandler, 30);
            ui.Run();
        }

        private static object Garage<T>(int v)
        {
            throw new NotImplementedException();
        }
    }

    internal class GarageHandlerr<T>  where T :IVehicle
    {
        
        private Garage<T> _garage;

        public GarageHandlerr(Garage<T> garage)
        {
            _garage = garage;
        }

        
    }
}
