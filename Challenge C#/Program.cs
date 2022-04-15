using System;
// using CSharpDiscovery.Quest01;
// using CSharpDiscovery.Quest02;
// using CSharpDiscovery.Quest03;
// using CSharpDiscovery.Quest04;
using CSharpDiscovery.Examen;

// using CSharpDiscovery.Models;
// using System.Collections.Generic;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------Quest 1------------------------------

            // Console.WriteLine(HelloWorld_Exercice.HelloWorld());
            // Console.WriteLine(AddTwoIntegers_Exercice.AddTwoIntegers(1, 2));
            // Console.WriteLine(AddTwoIntegers_Exercice.AddTwoIntegers(10, 5));
            // Console.WriteLine(IsOdd_Exercice.IsOdd(2));
            // Console.WriteLine(IsOdd_Exercice.IsOdd(11));
            // Console.WriteLine(IsOdd_Exercice.IsOdd(30));
            // Console.WriteLine(CSharpDiscovery.Quest01.SetPiValue_Exercice.SetPiValue(0));
            // Console.WriteLine(SpellItBackwards_Exercice.SpellItBackward("helloworld"));
            // var inputTab = new int[] { 1, 32, 7, 33 };
            // Console.WriteLine("{0}", string.Join(" ", DoubleArrayForEvenInteger_Exercice.DoubleArrayForEvenInteger(inputTab)));
            // Console.WriteLine(GetStringSize_Exercice.GetStringSize("helloworld"));
            // Console.WriteLine(Capitalize_Exercice.Capitalize("helloworld"));
            // Console.WriteLine(RemoveSpaces_Exercice.RemoveSpaces("  helloworld  "));
            // string[] table = { "hello", "world" };
            // Console.WriteLine(ConcatEverything_Exercice.ConcatEverything(table));
            // Console.WriteLine(ContainsSpecificSubstring_Exercice.ContainsSpecificSubstring("helloworld", "hello"));
            // Console.WriteLine(ContainsSpecificSubstring_Exercice.ContainsSpecificSubstring("helloworld", "monde"));
            // Console.WriteLine(BeginsWithSpecificCharacter_Exercice.BeginsWithSpecificCharacter("helloworld", 'h'));
            // Console.WriteLine(BeginsWithSpecificCharacter_Exercice.BeginsWithSpecificCharacter("helloworld", 'w'));
            // Console.WriteLine(NextTrafficLightColor_Exercice.GetNextTrafficLightColor(TrafficLightColor.Red));
            // Console.WriteLine(NextTrafficLightColor_Exercice.GetNextTrafficLightColor(TrafficLightColor.Orange));
            // Console.WriteLine(NextTrafficLightColor_Exercice.GetNextTrafficLightColor(TrafficLightColor.None));


            // -----------------Quest 2-----------------------------

            // Console.WriteLine(DisplayDateWithoutTime_Exercice.DisplayDateWithoutTime(new DateTime(2021, 1, 14)));
            // Console.WriteLine(TodayAtMidnight_Exercice.TodayAtMidnight());
            // var start = new DateTime(2021, 02, 01, 12, 0, 0, 0);
            // var end = new DateTime(2021, 02, 01, 18, 0, 0, 0);
            // Console.WriteLine(DifferenceInMinutes_Exercice.DifferenceInMinutes(start, end));
            // Console.WriteLine(FromStringToDateTime_Exercice.FromStringToDateTime("21/12/2021 18:33"));
            // var tab = new int[5] { 99, 98, 92, 97, 95 };
            // var tab2 = new int[5] { 50, 54, 85, 47, 2 };
            // Console.WriteLine(ContainsThisValue_Exercice.ContainsThisValue(tab, 97));
            // Console.WriteLine(ContainsThisValue_Exercice.ContainsThisValue(tab2, 51));
            // var array = new int[] { 3, 24, 13, 4, 40 };
            // Console.WriteLine(string.Join(", ", SortTable_Exercice.SortTable(array)));
            // var tab = new int[] { 1, 2, 3, 4, 6 };
            // var tab2 = new int[] { 1, 2, 3, 4, 6 };
            // var tab3 = new int[] { 1, 2, 3, 4, 5 };
            // Console.WriteLine(AreEquals_Exercice.AreEquals(tab2, tab3));
            // Console.WriteLine(AreEquals_Exercice.AreEquals(tab, tab2));
            // var tab = new int[] { 20, 35, 12, 56, 35, 76 };
            // Console.WriteLine(FindLastIndex_Exercice.FindLastIndex(tab, 12));
            // Console.WriteLine(FindLastIndex_Exercice.FindLastIndex(tab, 35));
            // Console.WriteLine(FindLastIndex_Exercice.FindLastIndex(tab, 66));
            // var people = new HashSet<string> { "Arnaud", "Marie", "Alexandre", "Audrey", "Adrien", "Mathilde", "Théophile", "Hanako" };
            // var draw = SecretSanta_Exercice.SecretSantaDraw(people);

            // foreach (KeyValuePair<string, string> pair in draw) {
            //     Console.WriteLine("{0} is offering to {1}", pair.Key, pair.Value);
            // }


            // -----------------Quest 3-----------------------------
           
            // var poi = new PointOfInterest();
            // Console.WriteLine(poi.Latitude);
            // Console.WriteLine(poi.Longitude);
            // Console.WriteLine(poi.Name);
            // Console.WriteLine(PointOfInterest.GoogleMapsUrlTemplate);

            //  var DefaultPoint = new PointOfInterest();
            // Console.WriteLine(DefaultPoint.Name);
            // Console.WriteLine(DefaultPoint.Latitude);
            // Console.WriteLine(DefaultPoint.Longitude);
            // var ParisCampus = new PointOfInterest("Paris Ynov Campus", 48.9016552, 2.2079985);
            // Console.WriteLine(ParisCampus.Name);
            // Console.WriteLine(ParisCampus.Latitude);
            // Console.WriteLine(ParisCampus.Longitude);

            // var DefaultPoint = new PointOfInterest();
            // Console.WriteLine(DefaultPoint.GetGoogleMapsUrl());
            // var ParisCampus = new PointOfInterest("Paris Ynov Campus", 48.9016552, 2.2079985);
            // Console.WriteLine(ParisCampus.GetGoogleMapsUrl());

            // var DefaultPoint = new PointOfInterest();
            // Console.WriteLine(DefaultPoint.ToString());

            // var ParisCampus = new PointOfInterest("Paris Ynov Campus", 48.9016552, 2.2079985);
            // Console.WriteLine(ParisCampus.ToString());

            // var BordeauxCampus = new PointOfInterest();
            // var ParisCampus = new PointOfInterest("Paris Ynov Campus", 48.9016552, 2.2079985);
            // Console.WriteLine(BordeauxCampus.GetDistance(ParisCampus));
            // Console.WriteLine(PointOfInterest.GetDistance(BordeauxCampus, ParisCampus));

            // var BordeauxCampus = new Campus();
            // BordeauxCampus.Capacity = 3000;
            // Console.WriteLine(BordeauxCampus.ToString());

            // PointOfInterest PorteCailhau = new HistoricalMonument("Porte Cailhau", 44.838336, -0.569446, 1493);
            // Console.WriteLine(PorteCailhau.ToString());


            // -----------------Quest 4-----------------------------

            // var RandomCar = new Car();
            // var Megane = new Car("Mégane", "Renault", "Yellow", 50);
            // Vehicule.WhoIsHere();

            // var Megane = new Car("Mégane", "Renault", "Yellow", 100);
            // Megane.Accelerate(50);
            // Console.WriteLine(Megane.CurrentSpeed);
            // Megane.Accelerate(50);
            // Console.WriteLine(Megane.CurrentSpeed);
            // Megane.Brake(160);
            // Console.WriteLine(Megane.CurrentSpeed);
            // Megane.Brake(40);
            // Console.WriteLine(Megane.CurrentSpeed);

            // var RandomTruck = new Truck();
            // var MAC = new Truck(2, "MAC", "White", 80);
            // var Renault = new Truck(3, "Renault", "Black", 20);
            // Vehicule.WhoIsHere();
            // RandomTruck.Accelerate(30);
            // MAC.Accelerate(40);
            // Renault.Brake(30);
            // Vehicule.WhoIsHere();

            // var i8 = new HybridCar("i8", "BMW", "White");
            // i8.BatteryLevel = 60;
            // i8.FuelLevel = 80;
            // Vehicule.WhoIsHere();

            // i8.Recharge();
            // i8.FillUp();
            // Console.WriteLine(i8.GetBatteryLevel());
            // Console.WriteLine(i8.GetFuelLevel());


            // -----------------Examen-------------------------------------------------------------------------
            var Monstre = new Warrior(true,"Monstre",10);
            Console.WriteLine("Un Monstre Guerrier est crée");
            Console.WriteLine(Monstre.ToString());

            Console.WriteLine("-------------------------------------------------------------");
            var Clerk = new Cleric();
            Console.WriteLine("Un Personage non joueur (Npc) est crée");
            Console.WriteLine(Clerk.ToString());

            Console.WriteLine("-------------------------------------------------------------");
            var Guerrier = new Warrior(false,"Roland",100);
            Console.WriteLine("Un Personnage est crée");
            Console.WriteLine(Guerrier.ToString());
            Console.WriteLine("Votre personnage a été crée le : "+Guerrier.GetDateCreation());

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(Guerrier.Name+" prend 10 degat");
            Guerrier.TakeDamage(10);
            Console.WriteLine(Guerrier.ToString());

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(Clerk.Name+" soigne "+Guerrier.Name);
            Clerk.CibledSpecial(Guerrier);
            Console.WriteLine(Guerrier.ToString());

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(Guerrier.Name+" essaie d'activer sont speciale mais rien ne se passe");
            Guerrier.Special();
            Console.WriteLine(Guerrier.ToString());
            Console.WriteLine("\n"+Monstre.Name+" attaque "+ Guerrier.Name);
            Guerrier.TakeDamage(50);
            Console.WriteLine(Guerrier.ToString());
            Console.WriteLine("\n"+Guerrier.Name+" essaie d'activer sont speciale , ça marche !");
            Guerrier.Special();
            Console.WriteLine(Guerrier.ToString());
            Console.WriteLine("-------------------------------------------------------------");
            var Paladin = new Paladin(0,"Angela",100);
            Console.WriteLine("Un Personage est crée");
            Console.WriteLine(Paladin.ToString());
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(Paladin.Name+" soigne "+Guerrier.Name+" et "+Clerk.Name);
            Paladin.DoubleHeal(Guerrier,Clerk);
            Console.WriteLine(Guerrier.ToString());
            Console.WriteLine(Clerk.ToString());
        }
    }
}