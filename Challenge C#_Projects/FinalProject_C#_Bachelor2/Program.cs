// using System;
// using CSharpDiscovery.Examen;

// namespace TestCSharp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // -----------------Examen-------------------------------------------------------------------------
//             var Monstre = new Warrior(true,"Monstre",10);
//             Console.WriteLine("Un Monstre Guerrier est crée");
//             Console.WriteLine(Monstre.ToString());

//             Console.WriteLine("-------------------------------------------------------------");
//             var Clerk = new Cleric();
//             Console.WriteLine("Un Personage non joueur (Npc) est crée");
//             Console.WriteLine(Clerk.ToString());

//             Console.WriteLine("-------------------------------------------------------------");
//             var Guerrier = new Warrior(false,"Roland",100);
//             Console.WriteLine("Un Personnage est crée");
//             Console.WriteLine(Guerrier.ToString());
//             Console.WriteLine("Votre personnage a été crée le : "+Guerrier.GetDateCreation());

//             Console.WriteLine("-------------------------------------------------------------");
//             Console.WriteLine(Guerrier.Name+" prend 10 degat");
//             Guerrier.TakeDamage(10);
//             Console.WriteLine(Guerrier.ToString());

//             Console.WriteLine("-------------------------------------------------------------");
//             Console.WriteLine(Clerk.Name+" soigne "+Guerrier.Name);
//             Clerk.CibledSpecial(Guerrier);
//             Console.WriteLine(Guerrier.ToString());

//             Console.WriteLine("-------------------------------------------------------------");
//             Console.WriteLine(Guerrier.Name+" essaie d'activer sont speciale mais rien ne se passe");
//             Guerrier.Special();
//             Console.WriteLine(Guerrier.ToString());
//             Console.WriteLine("\n"+Monstre.Name+" attaque "+ Guerrier.Name);
//             Guerrier.TakeDamage(50);
//             Console.WriteLine(Guerrier.ToString());
//             Console.WriteLine("\n"+Guerrier.Name+" essaie d'activer sont speciale , ça marche !");
//             Guerrier.Special();
//             Console.WriteLine(Guerrier.ToString());
//             Console.WriteLine("-------------------------------------------------------------");
//             var Paladin = new Paladin(0,"Angela",100);
//             Console.WriteLine("Un Personage est crée");
//             Console.WriteLine(Paladin.ToString());
//             Console.WriteLine("-------------------------------------------------------------");
//             Console.WriteLine(Paladin.Name+" soigne "+Guerrier.Name+" et "+Clerk.Name);
//             Paladin.DoubleHeal(Guerrier,Clerk);
//             Console.WriteLine(Guerrier.ToString());
//             Console.WriteLine(Clerk.ToString());
//         }
//     }
// }