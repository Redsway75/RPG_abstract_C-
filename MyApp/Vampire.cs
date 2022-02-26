namespace MyApp
{
    public class Vampire:Enemy
    {
        public override void Attack(Player enemy){
            if(enemy.HP > 0){
                Console.WriteLine("");
                Console.WriteLine(this.Name+" mordeu " +enemy.Name);
                enemy.HP = enemy.HP - 35;
                Console.WriteLine($"{enemy.Name} tem {enemy.HP} de vida");
                Console.WriteLine("");
                this.MagicPoints=this.MagicPoints+15;
                if(enemy.HP <= 0){Console.WriteLine(this.Name+"Matou "+enemy.Name);
                this.MagicPoints=this.MagicPoints+30;
                this.Level=this.Level+1;
                Console.WriteLine("");
                Console.WriteLine($"{this.Name} subiu de nivel! level atual: {this.Level}!");
                Console.WriteLine($"{this.Name} tem {this.MagicPoints} de mana!");
                Console.WriteLine("");
                }
            }
             else{Console.WriteLine("O inimigo já está eliminado");}
         }
         
         public override void SpecialAttack(Player enemy){
            if(this.MagicPoints >= 45){
             if(enemy.HP > 0){
             Console.WriteLine(this.Name+" mordeu o pescoço e sugou a vida de "+enemy.Name);
             enemy.HP = enemy.HP - 50;
             Console.WriteLine("");
             Console.WriteLine($"{enemy.Name} tem {enemy.HP} de vida");
             Console.WriteLine("");
             this.MagicPoints=this.MagicPoints-85;
             Console.WriteLine($"{this.Name} tem {this.MagicPoints} de mana");
             this.HP = 100;
             Console.WriteLine($"{this.Name} recuperou vida ({this.HP} de HP)");
             Console.WriteLine("");
                if(enemy.HP <= 0){
                    Console.WriteLine(this.Name+"Matou "+enemy.Name);
                    this.Level=this.Level+1;
                    this.MagicPoints=this.MagicPoints+60;
                    Console.WriteLine($"{this.Name} tem {this.MagicPoints} de mana no total");
                }
             }
             else{Console.WriteLine("O inimigo já está eliminado");}
            }
            else{Console.WriteLine("Mana insuficiente para desferir o ataque!");}
         }
         public override void skill(Player enemy){
             if(this.MagicPoints >= 30){
                if(enemy.HP > 0){ 
                Console.WriteLine($"{this.Name} Arremeçou {enemy.Name} para longe");
                enemy.HP = enemy.HP - 25;
                Console.WriteLine("");
                Console.WriteLine($"{enemy.Name} tem {enemy.HP} de vida");
                this.MagicPoints=this.MagicPoints - 30;
                Console.WriteLine($"{this.Name} tem {this.MagicPoints} de mana");
                Console.WriteLine("");
                    if(enemy.HP <= 0){
                        Console.WriteLine($"{this.Name} matou {enemy.Name}");
                        this.Level=this.Level+1;
                        this.MagicPoints=this.MagicPoints+25;
                        Console.WriteLine($"{this.Name} tem {this.MagicPoints} de mana");
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
                Console.WriteLine("");
                Console.WriteLine($"{this.Name} tem {this.MagicPoints} de mana");
                Console.WriteLine("");
         }
            else{Console.WriteLine("Mana insuficiente para se defender!");}
         }
    } 
}