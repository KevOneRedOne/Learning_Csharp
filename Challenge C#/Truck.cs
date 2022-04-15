using System;

namespace CSharpDiscovery.Quest04
{
    public class Truck : Vehicule {

        public int Tonnage{set;get;}

        public Truck() {
            Tonnage = 0;
        }

        public Truck(int Tonnage, string Brand, string Color, int CurrentSpeed) : base(){
            this.Tonnage = Tonnage;
            this.Brand = Brand;
            this.Color = Color;
            this.CurrentSpeed = CurrentSpeed;
        }

        public override string ToString()
        {
            return Color+" "+Brand+" "+Tonnage+"T Truck";
        }

        public override void Accelerate(int Speed)
        {
            this.CurrentSpeed += Speed;

            if (this.CurrentSpeed > 100)
            {
                this.CurrentSpeed = 100;
            }

        }

        public override void Brake(int BrakePower)
        {
            this.CurrentSpeed -= BrakePower;

            if (this.CurrentSpeed < 0)
            {
                this.CurrentSpeed = 0;
            }
        }
    }
}