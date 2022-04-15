using System;

namespace CSharpDiscovery.Quest04
{
    public class Car : Vehicule {

        public String Model {set; get;} = "Unknown";

        public Car(){
            Brand = "Unknown";
        }

        public Car(String Model, String Brand, String Color, int CurrentSpeed) : base(){
            this.Model = Model;
            this.Brand = Brand;
            this.Color = Color;
            this.CurrentSpeed = CurrentSpeed;
        }

        public override string ToString()
        {
            return this.Color+ " " + this.Brand + " " + this.Model;
        }

        public override void Accelerate(int Speed)
        {
            this.CurrentSpeed += Speed;

            if (this.CurrentSpeed > 180)
            {
                this.CurrentSpeed = 180;
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