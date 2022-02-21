namespace MyApp
{
    public class npc : Character
    {
        public string Specialization;
        public string Guild;

         public npc(string name, string type, int level, int hp, int magicpoints, string Specialization, string Guild): base(name, type, level, hp, magicpoints){
             this.Specialization = Specialization;
             this.Guild = Guild;
        }

        public override string ToString()
        {
            return this.Name +" "+ this.Type +" "+ this.Level +" "+ this.HP +" "+ this.MagicPoints +" "+ this.Specialization +" "+ this.Guild;
        }
    }
}