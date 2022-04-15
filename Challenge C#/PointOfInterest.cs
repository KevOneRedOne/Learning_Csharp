using System;

namespace CSharpDiscovery.Quest03
{
    public class PointOfInterest {

        public static string GoogleMapsUrlTemplate {set;get;} = "https://www.google.com/maps/place/{0}/@{1},{2},15z/"; 
        public Double Latitude {get; set;}
        public Double Longitude {get; set;}
        public String Name {get; set;} ="";

        public PointOfInterest(){
            this.Name = "Bordeaux Ynov Campus";
            this.Latitude = 44.854186;
            this.Longitude = -0.5663056;
        }

        public PointOfInterest(String Name, Double Latitude, Double Longitude){
            this.Name = Name;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
        }

        public String GetGoogleMapsUrl(){
            return "https://www.google.com/maps/place/"+ Name.Replace(' ','+')+"/@"+Latitude+","+Longitude+",15z/";
        }

        public override string ToString()
        {
            return Name + " (Lat="+Latitude + ", Long=" + Longitude +")";
        }

        public int GetDistance(PointOfInterest other)
        {
            double LatOther = Math.PI*other.Latitude/180;
            double Latdefaut = Math.PI*this.Latitude/180;
            double theta = other.Longitude - this.Longitude;
            double rtheta = Math.PI*theta/180;
            double dist = Math.Sin(LatOther)*Math.Sin(Latdefaut)+ Math.Cos(LatOther)*Math.Cos(Latdefaut)*Math.Cos(rtheta);
            dist = Math.Acos(dist);
            dist = dist*180/Math.PI;
            dist = dist*60*1.1515;
            dist = dist*1.609344;
            return (int)dist+1;
        }

        public static int GetDistance(PointOfInterest p1, PointOfInterest p2)
        {
            double radianlat1 = Math.PI*p1.Latitude/180;
            double radianlat2 = Math.PI*p2.Latitude/180;
            double theta = p1.Longitude - p2.Longitude;
            double rtheta = Math.PI*theta/180;
            double dist = Math.Sin(radianlat1)*Math.Sin(radianlat2)+ Math.Cos(radianlat1)*Math.Cos(radianlat2)*Math.Cos(rtheta);
            dist = Math.Acos(dist);
            dist = dist*180/Math.PI;
            dist = dist*60*1.1515;
            dist = dist * 1.609344;
            return (int)dist+1;
        }
    }

}