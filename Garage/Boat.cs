using System;
namespace GarageApp
{
    public class Boat : Vehicle
    {
        private object? BoatType;

        public bool IsSport { get; set; }
        public bool IsCargoBoat { get; set; }

        
        public override string ToString()
        {
            return base.ToString() + $", Type: {BoatType}";
        }


    }
    }




