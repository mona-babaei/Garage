using System;
namespace GarageApp;

	public class Car:Vehicle
    {    
      
        
        public bool IsSport { get; set; }
        public bool IsCargoVehicle { get; set; }

        public override void Start()
        {
            Console.WriteLine("Car started.");
        }

        public  override void Stop()
        {
            Console.WriteLine("Car stopped.");
        }
    }




    //Gasoline eller Diesel



