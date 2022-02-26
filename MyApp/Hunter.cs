namespace MyApp
{
    public class Hunter:Enemy
    {
        public override void Attack(Player enemy){
            if(enemy.HP > 0){
            Console.WriteLine(this.Name+" Desferiu golpes de machado em " +enemy.Name);
             enemy.HP = enemy.HP - 25;
             this.MagicPoints=this.MagicPoints+25;
             Console.WriteLine($"{enemy.Name} tem {enemy.HP} de vida");
             Console.WriteLine($"{this.Name} tem {this.MagicPoints} de mana!");
                if(enemy.HP <= 0){Console.WriteLine(this.Name+"Matou "+enemy.Name);
                this.MagicPoints=this.MagicPoints+25;
                this.Level=this.Level+1;
                Console.WriteLine($"{this.Name} tem {this.MagicPoints} de mana!");
                }
            }
             else{Console.WriteLine("O inimigo já está eliminado");}
         }
         
         public override void SpecialAttack(Player enemy){
            if(this.MagicPoints >= 50){
             if(enemy.HP > 0){
             Console.WriteLine(this.Name+"jogou gás venenoso em"+enemy.Name);
             enemy.HP = enemy.HP - 65;
             Console.WriteLine($"{enemy.Name} tem {enemy.HP} de vida");
             Console.WriteLine($"{this.Name} tem {this.MagicPoints} de mana!");
             this.MagicPoints=this.MagicPoints-50;
                if(enemy.HP <= 0){
                    Console.WriteLine(this.Name+"Matou "+enemy.Name);
                    this.Level=this.Level+1;
                    this.MagicPoints=this.MagicPoints+60;
                    Console.WriteLine($"{this.Name} tem {this.MagicPoints} de mana!");
                }
             }
             else{Console.WriteLine("O inimigo já está eliminado");}
            }
            else{Console.WriteLine("Mana insuficiente para desferir o ataque!");}
         }
         public override void skill(Player enemy){
             if(this.MagicPoints >= 10){
                if(enemy.HP > 0){ 
                Console.WriteLine($"{this.Name} Atirou flechas em {enemy.Name}");
                enemy.HP = enemy.HP - 15;
                this.MagicPoints=this.MagicPoints - 10;
                Console.WriteLine($"{enemy.Name} tem {enemy.HP} de vida");
                Console.WriteLine($"{this.Name} tem {this.MagicPoints} de mana!");
                    if(enemy.HP <= 0){
                        Console.WriteLine($"{this.Name} matou {enemy.Name}");
                        this.Level=this.Level+1;
                        this.MagicPoints=this.MagicPoints+40;
                        Console.WriteLine($"{this.Name} tem {this.MagicPoints} de mana!");
                    }
         }
                else{Console.WriteLine("O inimigo já está eliminado");}
             }
            else{Console.WriteLine("Mana insuficiente para desferir oa taque");}
         }
             
         public override void Defend(Player enemy){
            if(this.MagicPoints>=35){
                Console.WriteLine($"{this.Name} se defendeu desviando dos ataques de {enemy.Name}");
                this.MagicPoints=this.MagicPoints-35;
                Console.WriteLine($"{this.Name} tem {this.MagicPoints} de mana!");
         }
            else{Console.WriteLine("Mana insuficiente para se defender!");}
         }
    } 
}