//Vehicle 
// Vehicle vehicle = new Vehicle();
// //var z = vehicle.VehicleNumber; //getter
// vehicle.VehicleNumber = "BA PA 3455" ; //SETTER
// var x = Vehicle.VehicleNumber;
// Console.WriteLine(x);




//Modify instantiation process EV = number, range, batteryCapacity
ElectricVehicle car1 = new ElectricVehicle("BA PA 3455", 420, 40);
EngineVehicle car2 = new EngineVehicle("BA PA 1234",5555, 6);
Console.WriteLine(car1.BatteryCapacity);


Generics g = new();
g.PrintDetails<string,int>("Hello",123);

