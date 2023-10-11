using System;
using System.Collections.Generic;

namespace GarageApp
{
public interface IHandler 
{
	bool AddVehicle(IVehicle vehicle);
	bool RemoveVehicle(string registeringsnummer);
    IVehicle  FindVehicleByRegNumber(string registeringsnumme);
    IEnumerable<IVehicle>
    FindVehiclesByProperties(string color, int numberOfWheels);
    IEnumerable<IVehicle> GetVehicles();
	int DisplayVehicleCount();
	
   
}        

}





//hantera add/remove