namespace MyApp
{
    public class Enemy : npc
    {
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