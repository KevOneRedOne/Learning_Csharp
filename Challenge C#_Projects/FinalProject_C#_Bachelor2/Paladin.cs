using System;

namespace CSharpDiscovery.Examen{

    public class Paladin : Character, IHealer, ITank  {
        public int Buff {set;get;} = 0;
        public int HealPower {set; get;}
        public int AttackIPower {set; get;}
        public Paladin() : base(){

        }
        public Paladin(int Buff, string Name, int HpMax) : base(){
            this.Buff = Buff;
            this.Name = Name;
            this.HpMax = HpMax;
        }

        public override string ToString()
        {
            return Name + " : " + Hp + "/" + HpMax + " |"+ " Classe : Paladin" + " |"+ " Buff : " + Buff;
        }

        public override void Special()
        {
            Hp += HealPower + Buff;
            if (Hp > HpMax)
            {
                Hp = HpMax;                
            }
        }

        public override void CibledSpecial(Character Char)
        {
            Char.Hp -= AttackIPower + (Buff * 3);

            if(Buff > 15) {
                Buff = 15;
            }

            if (Char.Hp < 0 ) {
                Char.Hp = 0;
            }
        }

        public void DoubleHeal(Character Char1, Character Char2){

        }
        public int GetHeal(){
            return HealPower;
        }

        public void BigAttack(Character Char){

        }
        public int GetPower(){
            return AttackIPower;
        }


    }
}
