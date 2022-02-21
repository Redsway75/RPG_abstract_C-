namespace MyApp
{
    public class Player : Character
    {
        public string Guild;
        public Player(string name, string type, int level, int hp, int magicpoints, string guild): base(name, type, level, hp, magicpoints){
            this.Guild = guild;
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