namespace MyApp
{
    public class Thief: Player
    {
         public override void Attack(Enemy monster){
            if(monster.HP>0){
            Console.WriteLine(this.Name+" Desferiu um ataque com adagas no " +monster.Name);
             monster.HP = monster.HP - 15;
             this.MagicPoints=this.MagicPoints+15;
                if(monster.HP <= 0){Console.WriteLine(this.Name+"Matou "+monster.Name);}
                this.MagicPoints=this.MagicPoints+25;
            }
             else{Console.WriteLine("O inimigo já está eliminado");}
         }
         
         public override void SpecialAttack(Enemy monster){
            if(this.MagicPoints >= 35){
             if(monster.HP != 0){
             Console.WriteLine(this.Name+"lançou 3 kunais no "+monster.Name);
             monster.HP = monster.HP - 35;
             this.MagicPoints=this.MagicPoints-35;
                if(monster.HP <= 0){
                    Console.WriteLine(this.Name+"Matou "+monster.Name);
                    this.Level=this.Level+1;
                    this.MagicPoints=this.MagicPoints+40;
                }
             }
             else{Console.WriteLine("O inimigo já está eliminado");}
            }
            else{Console.WriteLine("Mana insuficiente para desferir o ataque!");}
         }
         public void Swipe(Enemy monster){
             if(this.MagicPoints >= 45){
              Console.WriteLine($"{this.Name} roubou {monster.Coin-100} de dinheiro de {monster.Name}");
              this.Coin = this.Coin+100;
              this.MagicPoints=this.MagicPoints - 45;
         }
            else{Console.WriteLine("Mana insuficiente para desferir oa taque");}
         }
         public override void Defend(Enemy monster){
            if(this.MagicPoints>=35){
             Console.WriteLine($"{this.Name} se defendeu desviando dos ataques de {monster.Name}");
             this.MagicPoints=this.MagicPoints-35;
         }
            else{Console.WriteLine("Mana insuficiente para se defender!");}
         }
    }    
}
