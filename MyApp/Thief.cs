namespace MyApp
{
    public class Thief: Player
    {
         public override string Attack(){
            return this.Name + "Desferiu um ataque com adagas no inimigo";
         }

         public override string SpecialAttack(){
             return this.Name +"Ficou invisivel";
         }
         public string Swipe(){
             return this.Name +"Roubou o dinheiro";
         }
         public override string Defend(){
             return this.Name + "Se defendeu desviando dos atque";
         }
    }
}