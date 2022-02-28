namespace MyApp
{
    public  class Character
    {
        private string _Name;
        public string Name{get {return this._Name;} set{_Name = value;}}
        public int Level;
        public int HP;
        public int Coin = 200;
        public int MagicPoints;
        public Character(){
            this.HP = 100;
            this.MagicPoints = 100;
            this._Name = "default";

        }
       

        public  void Attack(Character monster){}
        public  void SpecialAttack(Character monster){}

        public  void skill(Character Monster){}
        public  void Defend(Character monster){}

        public override string ToString(){
            return this.Name +" "+ this.Level +" "+ this.HP +" "+ this.MagicPoints;
        }

    }
}