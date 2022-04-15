using System;

namespace CSharpDiscovery.Examen{

    public class Warrior : Character, ITank {
        public int AttackIPower {set;get;}
        public Boolean Bravery {set; get;} = false;
        public Warrior(): base(){
            AttackIPower = 25;
        }

        public Warrior(Boolean Bravery, String Name, float HpMax): base() {
            this.Bravery = Bravery;
            this.Name = Name;
            this.HpMax = HpMax; 
        }

        public override string ToString()
        {
            return Name + " : " + Hp + "/" + HpMax +" |"+ " Classe : Guerrier" + " |" + " Bravoure : " + Bravery;
        }

        public override void Special()
        {
            if (Hp < 30)
            {
                Bravery = true;
            }
        }
        public override void CibledSpecial(Character Char)
        {
            Char.Hp -= AttackIPower;
            if (Bravery == true)
            {
                Char.Hp += 15;
            }

            if (Char.Hp < 0)
            {
                Char.Hp = 0;
            }
        }

        public void BigAttack(Character Char){
            this.Hp -= 10; 
            Char.Hp -= AttackIPower*2;
        }

    }
}