namespace MyApp
{
    public class Friendly: npc
     {
        public Friendly(string name, string type, int level, int hp, int magicpoints, string Specialization, string Guild): base(name, type, level, hp, magicpoints, Specialization, Guild){

        }
         public string Attack(){
            return this.Name + "atacou";
         }

         public string RunnAway(){
             return this.Name + "Fugiu";
         }

         public string Shield(){
             return this.Name + "Se defendeu";
         }
    }
}