namespace MyApp
{
    public class Divine: Player
    { 
       public override void Attack(Enemy monster){
            if(monster.HP>0){
            Console.WriteLine(this.Name+" desferiu um ataque letal com sua espada sagrada no " +monster.Name);
             monster.HP = monster.HP - 30;
             Console.WriteLine($"{monster.Name} tem {monster.HP} de vida");
             this.MagicPoints=this.MagicPoints+15;
                if(monster.HP <= 0){Console.WriteLine(this.Name+"Matou "+monster.Name);}
                this.MagicPoints=this.MagicPoints+25;
                this.Level=this.Level+1;
            }
             else{Console.WriteLine("O inimigo já está eliminado");}
         }
         
         public override void SpecialAttack(Enemy monster){
            if(this.MagicPoints >= 85){
             if(monster.HP != 0){
             Console.WriteLine(this.Name+" exorcizou "+monster.Name);
             monster.HP = monster.HP - 75;
             Console.WriteLine($"{monster.Name} tem {monster.HP} de vida");
             this.MagicPoints=this.MagicPoints-85;
             Console.WriteLine($"{this.Name} tem {this.MagicPoints} de mana!");
                if(monster.HP <= 0){
                    Console.WriteLine(this.Name+"Matou "+monster.Name);
                    this.Level=this.Level+1;
                    this.MagicPoints=this.MagicPoints+40;
                    Console.WriteLine($"Subiu de level (+1)! +40 de MP!(total:{this.MagicPoints} de mana)");
                }
             }
             else{Console.WriteLine("O inimigo já está eliminado");}
            }
            else{Console.WriteLine("Mana insuficiente para desferir o ataque!");}
         }
         public void skill(Player friend){
             if(this.MagicPoints >= 25){
              Console.WriteLine($"{this.Name} curou com sua magia dinvina {friend.Name}");
              this.MagicPoints=this.MagicPoints - 25;
              Console.WriteLine($"{this.Name} tem {this.MagicPoints} de mana");
                if(friend.HP>0 && friend.HP <100){
                    friend.HP = 100;
                    Console.WriteLine($"{friend.Name} tem {friend.HP} de vida");
                }

         }
            else{Console.WriteLine("Mana insuficiente para desferir oa taque");}
         }
         public override void Defend(Enemy monster){
            if(this.MagicPoints>=35){
             Console.WriteLine($"{this.Name} bloqueou ataques de {monster.Name} usando o escudo sagrado");
             this.MagicPoints=this.MagicPoints-35;
             Console.WriteLine($"{this.Name} tem {this.MagicPoints} de mana");
         }
            else{Console.WriteLine("Mana insuficiente para se defender!");}
         }
    }  
}