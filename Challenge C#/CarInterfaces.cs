namespace CSharpDiscovery.Quest04
{
    public interface IThermalCar
    {
        int FuelLevel {set; get;}
        public void FillUp(){

        }
        public int GetFuelLevel(){
            return FuelLevel;
        }


    }

    public interface IElectricCar{
        int BatteryLevel {set;get;}

        public void Recharge(){

        }
        public int GetBatteryLevel(){
            return BatteryLevel;
        }

    }
}