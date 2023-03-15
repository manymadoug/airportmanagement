using AM.ApplicationCore;
using AM.ApplicationCore.Domain;

/*Plane plane= new Plane(); 
plane.Capacity= 1;
plane.ManufactureDate = new DateTime(2018, 10, 09);
plane.PlaneType = PlaneType.Airbus;*/

//Plane plane2 = new Plane(PlaneType.Boing,1,DateTime.Now);

Plane plane2 = new Plane
{
    Capacity = 1,
    ManufactureDate = new DateTime(),
    PlaneType = PlaneType.Airbus
};

List<Flight> flights = new List<Flight>();