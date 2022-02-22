namespace MyApp
{
    public class Knight: Player
    {
         public override string Attack(){
            return this.Name + "Desferiu um ataque de espada no inimigo";
         }

         public override string SpecialAttack(){
             return this.Name +"Invocou o modo berserker";
         }
         public string Bomb(){
             return this.Name +"Jogou bomba";
         }
         public override string Defend(){
             return this.Name + "Se defendeu com o escudo";
         }
         } 
    }