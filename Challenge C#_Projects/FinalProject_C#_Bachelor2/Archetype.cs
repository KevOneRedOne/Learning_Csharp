namespace CSharpDiscovery.Examen {

    public interface IHealer {
        int HealPower {set; get;}

        void DoubleHeal(Character Char1, Character Char2){

        }
        int GetHeal(){
            return HealPower;
        }
    }

    public interface ITank{
        int AttackIPower {set;get;}
        void BigAttack(Character Char){

        }
        int GetPower(){
            return AttackIPower;
        }


    }


}