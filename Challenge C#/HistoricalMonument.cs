using System;

namespace CSharpDiscovery.Quest03
{
    public class HistoricalMonument : PointOfInterest {

        public int BuildYear{set;get;}

        public HistoricalMonument(){
            
        }
        public HistoricalMonument(String Name, Double Latitude, Double Longitude, int BuildYear) : base(){
            this.Name =Name;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
            this.BuildYear = BuildYear;
        }
            
        public override string ToString()
        {
            return this.Name +" is a historical monument built in "+ this.BuildYear;
        }

    }
    
}