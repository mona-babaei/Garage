using System;
namespace GarageApp
{

    public class Car : Vehicle
    {


        public bool IsSport { get; set; }
      //  public bool IsCargoVehicle { get; set; }
       /* public  string ToString()
        {
            return $"Car - Registration Number: {Registreringsnummer}, Color: {Color}, Number of Wheels: {NumberOfWheels}";
        }*/

       

        public override string ToString()
        {
            return base.ToString() + $", IsSport: {IsSport}";
        }

    }
}





   



