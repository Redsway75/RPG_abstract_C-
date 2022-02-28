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
               Console.WriteLine($"{this.Name}: +15 de mana");
               Console.WriteLine("");
                if(monster.HP <= 0){Console.WriteLine(this.Name+" Matou "+monster.Name);}
                   this.MagicPoints=this.MagicPoints+25;
                  this.Level=this.Level+1;
                  Console.WriteLine($"{this.Name} subiu de leve! level atual: {this.Level}");
                  Console.WriteLine($"{this.Name}: +25 de mana");
                  Console.WriteLine("");
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
               Console.WriteLine($"{this.Name}: -85 de mana");
               Console.WriteLine("");
                if(monster.HP <= 0){
                    Console.WriteLine(this.Name+" Matou "+monster.Name);
                    this.Level=this.Level+1;
                    this.MagicPoints=this.MagicPoints+40;
                    Console.WriteLine($"{this.Name}: +40 de mana");
                    Console.WriteLine($"Subiu de level (+1)! +40 de MP!");
                    Console.WriteLine("");
                }
             }
             else{Console.WriteLine("O inimigo já está eliminado");}
            }
            else{Console.WriteLine("Mana insuficiente para desferir o ataque!");}
         }
         public override void skill(Enemy monster){
             if(this.MagicPoints >= 35){
              Console.WriteLine($"{this.Name} curou-se com sua magia divina");
              this.MagicPoints=this.MagicPoints - 35;
              Console.WriteLine($"{this.Name}: -35 de mana");
              Console.WriteLine("");
                if(this.HP>0 && this.HP <100){
                     this.HP = 100;
                     Console.WriteLine($"Curou-se com a magia sagrada!!! {this.Name} tem {this.HP} de vida agora!");
                     Console.WriteLine("");
                }

         }
            else{Console.WriteLine("Mana insuficiente para desferir oa taque");}
         }
         public override void Defend(Enemy monster){
            if(this.MagicPoints>=35){
             Console.WriteLine($"{this.Name} bloqueou ataques de {monster.Name} usando o escudo sagrado");
             this.MagicPoints=this.MagicPoints-35;
             Console.WriteLine($"{this.Name}: -35 de mana");
             Console.WriteLine("");
         }
            else{Console.WriteLine("Mana insuficiente para se defender!");}
         }
    }  
}