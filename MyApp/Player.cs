namespace MyApp
{
    public class Player : Character
    {
        private string Guild_;
        public string Guild{
            get{return Guild_;}
            set{Guild_ = value;}
        }
        public Player(){
            this.Level = 1;
            this.Guild_ = "none";
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
        public override string ToString(){
            return this.Name +" "+ this.Level +" "+ this.HP +" "+ this.MagicPoints;
        }
         
    }
}