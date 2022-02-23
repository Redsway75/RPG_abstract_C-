namespace MyApp
{
    public class Character
    {
        private string _Name;
        public string Name{get {return this._Name;} set{_Name = value;}}
        public int Level;
        public int HP;
        public int MagicPoints;
        public Character(){
            this.HP = 100;
            this.MagicPoints = 100;
            this._Name = "default";
        }

        public override string ToString(){
            return this.Name +" "+ this.Level +" "+ this.HP +" "+ this.MagicPoints;
        }

    }
}