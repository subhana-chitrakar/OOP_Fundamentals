public abstract class Vehicle {

public Vehicle(string number) {
  vehicleNumber = number;
}



String vehicleNumber;


  public string VehicleNumber{  //properties
    get => vehicleNumber;
    set {
      if (value != "" && value.Length >5){
        vehicleNumber = value;
      }
    }
  }

  public string Brand {get; set;} = " ";
 
  public DateTime Year {get; set;}
  public VehicleType Type {get; set;} = VehicleType.Wagon;


}