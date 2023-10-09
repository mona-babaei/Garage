using System;
using System.Security.Cryptography;

namespace GarageApp;

public interface IHandler 
{
	bool AddVehicle(IVehicle vehicle);
	bool RemoveVehicle(string registeringsnummer);
    IVehicle  FindVehicleByRegNumber(string registeringsnumme);
    IEnumerable<IVehicle>
    FindVehiclesByProperties(string color, int numberOfWheels);
    IEnumerable<IVehicle> GetVehicles();
	int DisplayVehicleCount();
	void FindvehicleByRegNumber();
	void VehicleSearcher1();

   }        







//hantera add/remove