using System;
namespace GarageApp
{

    public class Bus : Vehicle
    {
        public int NumberOfSeats { get; set; } = 33;
        public bool IsDoubleDecker { get; set; }
  

        public override string ToString()
        {
            return base.ToString() + $", Capacity: {NumberOfSeats}, Double Decker: {IsDoubleDecker}";
        }

    }
}






