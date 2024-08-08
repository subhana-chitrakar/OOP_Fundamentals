public class Vehicle {

String vehicleNumber;


  public string VehicleNumber{  //properties
    get => vehicleNumber;
    set {
      if (value != 0 && value.Length >5){
        vehicleNumber = value;
      }
    }
  }

  public string Brand {get; set;} = " ";
 
  public DateTime Year {get; set;}
  public VehicleType Type {get; set;} = VehicleType.Wagon;
}