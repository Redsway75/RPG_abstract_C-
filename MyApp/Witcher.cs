namespace MyApp
{
     public class Witcher: Player
    {
       
         public override string Attack(){
            return this.Name + "Lançou uma magia";
         }

         public override string SpecialAttack(){
             return this.Name +"Canalizou uma bola de fogo";
         }
         public string RestoreMP(){
             return this.Name +"Recarrega mana do grupo";
         }
         public override string Defend(){
             return this.Name + "Usou campo de força";
         }
    }
    
}