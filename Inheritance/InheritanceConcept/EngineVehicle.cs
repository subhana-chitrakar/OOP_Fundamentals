public class EngineVehicle : Vehicle, IVehicle //multiple inheritance is possible with interfaces. It inherits from Vehicles and implements from IVehicle

{

     public EngineVehicle(string number,float enginecc, float mileage) : base(number)
    {
        this.EngineCC = enginecc;
        this.Mileage = mileage;
    }



    public float EngineCC { get; set; }
    public float Mileage { get; set; }
    //we have to implement interface 
    public float GetDistanceCovered(float oilUsed) => Mileage * oilUsed;

}