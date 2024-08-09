public class ElectricVehicle : Vehicle,IVehicle  //syntax for inheritance
{
    public ElectricVehicle(string number, int batteryCapacity , short range) : base(number)
    {
        this.BatteryCapacity = batteryCapacity;
        this.Range = range;
    }



    public int BatteryCapacity{ get; set;}
    public short Range {get; set;}


    public float GetDistanceCovered(float batteryUsedPercentage){
          var mileageForBatteryUsed = Range / 100 * batteryUsedPercentage;
          return mileageForBatteryUsed;
    }

}