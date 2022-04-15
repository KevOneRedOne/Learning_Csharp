using System;

namespace CSharpDiscovery.Examen
{
    public abstract class Character {

        public String Name {set; get;} = "";
        public float Hp {set; get;}
        public float HpMax {set; get;}
        public static DateTime CreationDate{set; get;} = DateTime.Now;

        public Character(){
            Name = "Npc";
            Hp = 100;
            HpMax = 100;
        }
        public Character(String Name, float Hp, float HpMax){
            this.Name = Name;
            this.Hp = Hp;
            this.HpMax = HpMax;
        }

        public override String ToString(){
            return Name + " : " + Hp + "/" + HpMax;
        }
         public void TakeDamage(int damage){
            Hp -= damage;
            if (Hp < 0)
            {
                Hp = 0;
            }
         }
         public String GetDateCreation() {
            DateTime date = DateTime.Now;
            return date.ToString("dd/MM HH:mm");
         }
         public abstract void Special();
         public abstract void CibledSpecial(Character Char);



    }
}