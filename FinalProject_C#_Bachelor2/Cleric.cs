using System;

namespace CSharpDiscovery.Examen{

    public class Cleric : Character, IHealer {

        public Double Mana {set; get;} = 100;
        public int HealPower{set;get;}
        public Cleric() : base(){
            HealPower = 15;
        }
        public Cleric(Double Mana, String Name, float HpMax): base() {
            this.Mana = Mana;
            this.Name = Name;
            this.HpMax = HpMax; 
        }
        public override string ToString()
        {
            return Name + " : " + Hp + "/" + HpMax + " |"+ " Classe : Clerc" +" |" +" Mana : " + Mana; 
        }
        public override void Special()
        {
            Mana += 10;
            if (Mana > 100)
            {
                Mana = 100;
            }
        }
        public override void CibledSpecial(Character Char)
        {
            Char.Hp += HealPower;
            if(Char.Hp > Char.HpMax) {
                Char.Hp = Char.HpMax;
            }
        }
        public void DoubleHeal(Character Char1, Character Char2){
            Char1.Hp += HealPower/2;
            Char2.Hp += HealPower/2;

            if (Char1.Hp > Char1.HpMax )
            {
                Char1.Hp = Char1.HpMax;
            }

            if (Char2.Hp > Char2.HpMax)
            {
                Char2.Hp = Char2.HpMax;
            }
        }

    }
}