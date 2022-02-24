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
         
         public virtual void Attack(Enemy monster){
              Console.WriteLine("Atacou");
         }
         public virtual void SpecialAttack(Enemy monster){
             Console.WriteLine("Ataque especial");
         }
         public virtual void Defend(Enemy monster){
             Console.WriteLine(this.Name +"Se defendeu");
         }

        public override string ToString(){
            return this.Name +" "+ this.Level +" "+ this.HP +" "+ this.MagicPoints;
        }
         
    }
}