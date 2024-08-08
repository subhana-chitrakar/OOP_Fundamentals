public class ElectricVehicle : Vehicle //syntax for inheritance
{
    public int BatteryCapacity{ get; set;}
    public short Range {get; set;}


    public float GetMileage(float distanceCovered, float batteryUsedPercentage){
      var energyConsumed = (batteryUsedPercentage * BatteryCapacity)/100 ;
      var energyConsumptionPerKm = energyConsumed/distanceCovered;
      var mileage = 1/energyConsumptionPerKm;
      return mileage;
    }

}