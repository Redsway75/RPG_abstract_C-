namespace MyApp
{
    public class Divine: Player
    { 
        public override string Attack(){
            return this.Name + "Desferiu um ataque com magia divina no inimigo";
         }

         public override string SpecialAttack(){
             return this.Name +"Abençou todas as armas do time (50%+ de dano)";
         }
         public string Health(){
             return this.Name +"Curou aliado ";
         }
         public override string Defend(){
             return this.Name + "Se defendeu com escudo";
         }
    }
}