namespace MyApp
{
    public class Zombie:Enemy
    {
        public override void Attack(Player enemy){
            if(enemy.HP > 0){
            Console.WriteLine(this.Name+" mordeu " +enemy.Name);
             enemy.HP = enemy.HP - 25;
             this.MagicPoints=this.MagicPoints+25;
                if(enemy.HP <= 0){Console.WriteLine(this.Name+"Matou "+enemy.Name);
                this.MagicPoints=this.MagicPoints+25;
                this.Level=this.Level+1;
                }
            }
             else{Console.WriteLine("O inimigo já está eliminado");}
         }
         
         public override void SpecialAttack(Player enemy){
            if(this.MagicPoints >= 45){
             if(enemy.HP > 0){
             Console.WriteLine(this.Name+"Atacou 5 vezes seguidas "+enemy.Name);
             enemy.HP = enemy.HP - 45;
             this.MagicPoints=this.MagicPoints-45;
                if(enemy.HP <= 0){
                    Console.WriteLine(this.Name+"Matou "+enemy.Name);
                    this.Level=this.Level+1;
                    this.MagicPoints=this.MagicPoints+60;
                }
             }
             else{Console.WriteLine("O inimigo já está eliminado");}
            }
            else{Console.WriteLine("Mana insuficiente para desferir o ataque!");}
         }
         public void Spew(Player enemy){
             if(this.MagicPoints >= 35){
                if(enemy.HP > 0){ 
                Console.WriteLine($"{this.Name} vomitou ácido em {enemy.Name}");
                enemy.HP = enemy.HP - 40;
                this.MagicPoints=this.MagicPoints - 35;
                    if(enemy.HP <= 0){
                        Console.WriteLine($"{this.Name} matou {enemy.Name}");
                        this.Level=this.Level+1;
                        this.MagicPoints=this.MagicPoints+40;
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
         }
            else{Console.WriteLine("Mana insuficiente para se defender!");}
         }
    } 
}