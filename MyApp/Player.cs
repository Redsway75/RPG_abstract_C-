namespace MyApp
{
    public class Player : Character
    {
        public string Guild;
        public Player(){
            this.Level = 1;
        }
         
         public virtual string Attack(){
             return this.Name+ "Atacou";
         }
         public virtual string SpecialAttack(){
             return this.Name + "Ataque especial";
         }
         public virtual string Defend(){
             return this.Name + "Se defendeu";
         }

         public string Recruit(){
             return this.Name +"Recrutou";
         }
         public string Dismiss(){
             return this.Name+ "Demitiu";
         }
    }
}