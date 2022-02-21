namespace MyApp
{
    public class Character
    {
        public string Name;
        public int Level;
        public string Type;
        public int HP;
        public int MagicPoints;

        public Character(string name, string type, int level, int hp, int magicpoints){
            this.Name = name;
            this.Type = type;
            this.Level = level;
            this.HP = hp;
            this.MagicPoints = magicpoints;
        }


        public override string ToString(){
            return this.Name +" "+ this.Type +" "+ this.Level +" "+ this.HP +" "+ this.MagicPoints;
        }

    }
}