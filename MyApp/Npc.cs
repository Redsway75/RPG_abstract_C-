namespace MyApp
{
    public class npc : Character
    {
        public string Specialization{get;set;} = string.Empty;
        public string Guild{get;set;} = string.Empty;

        public override string ToString()
        {
            return this.Name +" "+ this.Level +" "+ this.HP +" "+ this.MagicPoints +" "+ this.Specialization +" "+ this.Guild;
        }
    }
}