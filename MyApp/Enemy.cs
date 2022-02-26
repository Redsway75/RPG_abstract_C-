namespace MyApp
{
    public class Enemy : Character
    {
         public virtual void Attack(Player enemy){
            Console.WriteLine(this.Name+" Desferiu um ataque com adagas no " +enemy.Name);
         }
         
         public virtual void SpecialAttack(Player enemy){
             Console.WriteLine(this.Name+"lançou 3 kunais no "+enemy.Name);
             }
         public virtual void skill(Player enemy){
              Console.WriteLine($"{this.Name} roubou {enemy.Coin-100} de dinheiro de {enemy.Name}");
         }
         public virtual void Defend(Player enemy){
             Console.WriteLine($"{this.Name} se defendeu desviando dos ataques de {enemy.Name}");
             } 
}
}