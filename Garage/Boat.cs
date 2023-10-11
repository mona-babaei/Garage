using System;
namespace GarageApp
{
    public class Boat : Vehicle
    {
        private object? BoatType;

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
        public override string ToString()
        {
            return base.ToString() + $", Type: {BoatType}";
        }


    }
    }




