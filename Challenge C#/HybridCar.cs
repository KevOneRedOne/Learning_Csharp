namespace CSharpDiscovery.Quest04
{
    public class HybridCar : Car, IElectricCar, IThermalCar {

        public HybridCar(){}

        public HybridCar(string Model, string Brand, string Color, int CurrentSpeed = 0) : base() {
            this.Model = Model;
            this.Brand = Brand;
            this.Color = Color;
            this.CurrentSpeed = CurrentSpeed;
        }   

        public int FuelLevel {get;set;} = 100;
        public void FillUp(){
            FuelLevel = 100;
        }
        public int GetFuelLevel(){
            return FuelLevel;
        }
        public int BatteryLevel{get;set;} = 100;
        public void Recharge(){
            BatteryLevel = 100;
        }
        public int GetBatteryLevel(){
            return BatteryLevel;
        }

        public override string ToString(){
            return Color+" "+Brand+" "+Model+ ", Battery: "+BatteryLevel+"%, Fuel: "+ FuelLevel+"%";
        }


    }

}

    