using System;
namespace GarageApp
{

    public class Motorcycle : Vehicle
    {
        public double CylinderVolume { get; set; } = 250.0; //250cc
        
        public override void Start()
        {
            Console.WriteLine("Motorcycle started.");
        }

        public override void Stop()
        {
            Console.WriteLine("Motorcycle stopped.");
        }


    }
}
		
	



