namespace MyApp
{
    public class Enemy : Character, ICharacter
    {
         public virtual void Attack(Player enemy){
         }
         
         public virtual void SpecialAttack(Player enemy){
             }
         public virtual void skill(Player enemy){
         }
         public virtual void Defend(Player enemy){
             Console.WriteLine($"{this.Name} se defendeu desviando dos ataques de {enemy.Name}");
             } 
}
}