namespace MyApp
{
    public class Character
    {
        public string Name {get{return this.Name;} set{Name = value;}}
        public int Level {get {return this.Level;} set{Level = value;}}
        public int HP;
        public int MagicPoints;

        public Character NullPointer {get {return this.NullPointer;} set{NullPointer = value;}}

        public Character(){
            this.NullPointer = null;
            this.HP = 100;
            this.MagicPoints = 100;
        }

        public override string ToString(){
            return this.Name +" "+ this.Level +" "+ this.HP +" "+ this.MagicPoints;
        }

    }
}