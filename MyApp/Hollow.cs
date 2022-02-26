namespace MyApp
{
    public class Hollow: Enemy
    {
        public override void Attack(Player enemy){
            if(enemy.HP > 0){
                Console.WriteLine(this.Name+" lançou orbes negros em " +enemy.Name);
                 enemy.HP = enemy.HP - 10;
                this.MagicPoints=this.MagicPoints+15;
                Console.WriteLine($"{enemy.Name} tem {enemy.HP} de vida");
                Console.WriteLine($"{this.Name} tem {this.MagicPoints} de mana!");
                if(enemy.HP <= 0){Console.WriteLine(this.Name+"Matou "+enemy.Name);
                    this.MagicPoints=this.MagicPoints+25;
                    this.Level=this.Level+1;
                    Console.WriteLine($"{this.Name} tem {this.MagicPoints} de mana!");
                    Console.WriteLine($"{this.Name} subiu de nivel! level atual: {this.Level}!");
                }
            }
             else{Console.WriteLine("O inimigo já está eliminado");}
         }
         
         public override void SpecialAttack(Player enemy){
            if(this.MagicPoints >= 35){
             if(enemy.HP > 0){
             Console.WriteLine(this.Name+"Corrompeu a alma de "+enemy.Name);
             enemy.HP = enemy.HP - 60;
             this.MagicPoints=this.MagicPoints-35;
             Console.WriteLine($"{this.Name} tem {this.MagicPoints} de mana!");
             Console.WriteLine($"{enemy.Name} tem {enemy.HP} de vida");
                if(enemy.HP <= 0){
                    Console.WriteLine(this.Name+"Matou "+enemy.Name);
                    this.Level=this.Level+1;
                    this.MagicPoints=this.MagicPoints+60;
                    Console.WriteLine($"{this.Name} tem {this.MagicPoints} de mana!");
                    Console.WriteLine($"{this.Name} subiu de nivel! level atual: {this.Level}!");
                }
             }
             else{Console.WriteLine("O inimigo já está eliminado");}
            }
            else{Console.WriteLine("Mana insuficiente para desferir o ataque!");}
         }
         public override void skill(Player enemy){
             if(this.MagicPoints >= 30){
                if(enemy.HP > 0){ 
                Console.WriteLine($"{this.Name} fez os ouvidos de {enemy.Name} sangrarem");
                enemy.HP = enemy.HP - 40;
                this.MagicPoints=this.MagicPoints - 30;
                Console.WriteLine("");
                Console.WriteLine($"{this.Name} tem {this.MagicPoints} de mana!");
                Console.WriteLine($"{enemy.Name} tem {enemy.HP} de vida");
                Console.WriteLine("");
                    if(enemy.HP <= 0){
                        Console.WriteLine($"{this.Name} matou {enemy.Name}");
                        this.Level=this.Level+1;
                        this.MagicPoints=this.MagicPoints+40;
                        Console.WriteLine("");
                        Console.WriteLine($"{this.Name} tem {this.MagicPoints} de mana!");
                        Console.WriteLine($"{this.Name} subiu de nivel! level atual: {this.Level}!");
                        Console.WriteLine("");
                    }
         }
                else{Console.WriteLine("O inimigo já está eliminado!");}
             }
            else{Console.WriteLine("Mana insuficiente para desferir o ataque!");}
         }
             
         public override void Defend(Player enemy){
            if(this.MagicPoints>=35){
                Console.WriteLine("");
                Console.WriteLine($"{this.Name} ficou invisil aos olhos de {enemy.Name}");
                this.MagicPoints=this.MagicPoints-35;
                Console.WriteLine($"{this.Name} tem {this.MagicPoints} de mana!");
                Console.WriteLine("");
         }
            else{Console.WriteLine("Mana insuficiente para se defender!");}
         }
    }
}