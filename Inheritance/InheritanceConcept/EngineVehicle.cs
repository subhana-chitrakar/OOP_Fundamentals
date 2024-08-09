public class EngineVehicle : Vehicle, IVehicle //multiple inheritance
{

     public EngineVehicle(string number,float enginecc, float mileage) : base(number)
    {
        this.EngineCC = enginecc;
        this.Mileage = mileage;
    }



    public float EngineCC { get; set; }
    public float Mileage { get; set; }
    public float GetDistanceCovered(float oilUsed) => Mileage * oilUsed;
}