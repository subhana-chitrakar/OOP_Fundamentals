//Vehicle 
// Vehicle vehicle = new Vehicle();
// vehicle.VehicleNumber = "BA PA 3455" ; //SETTER
// var x = Vehicle.VehicleNumber; //getter
// Console.WriteLine(x);




//Modify instantiation process EV = number, range, batteryCapacity
IVehicle car1 = new ElectricVehicle("BA PA 3455", 420, 40);
IVehicle car2 = new EngineVehicle("BA PA 1234",5555, 6);
Console.WriteLine(car2.GetDistanceCovered(20f));


// Generics g = new();
// g.PrintDetails<string,int>("Hello",123);

