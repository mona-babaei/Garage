using System;
namespace GarageApp
{
    public class Boat : Vehicle
    {


        public bool IsSport { get; set; }
        public bool IsCargoBoat { get; set; }

        public override void Start()
        {
            Console.WriteLine("Boat started.");
        }

        public override void Stop()
        {
            Console.WriteLine("Boat stopped.");
        }
    }



}


