namespace MyApp
{
     public class Witcher: Player
    {
       
         public override void Attack(Enemy monster){
           if(monster.HP > 0){
             Console.WriteLine(this.Name+" Lançou uma magia de flecha de almas no " +monster.Name);
             monster.HP = monster.HP - 25;
             this.MagicPoints=this.MagicPoints+15;
                if(monster.HP <= 0){Console.WriteLine(this.Name+"Matou "+monster.Name);}
                this.MagicPoints=this.MagicPoints+25;
             }
             else{Console.WriteLine("O inimigo já está eliminado");}
         }

         public override void SpecialAttack(Enemy monster){
            if(this.MagicPoints > 65){ 
                if(monster.HP > 0){
                Console.WriteLine(this.Name+" Canalizou e lançou uma orbe de fogo no " +monster.Name);
                monster.HP = monster.HP - 55;
                this.MagicPoints = this.MagicPoints-65;
                    if(monster.HP <= 0){
                        Console.WriteLine(this.Name+"Matou "+monster.Name);
                        this.Level = this.Level+1;
                        this.MagicPoints=this.MagicPoints+70;
                }
                else{Console.WriteLine("O inimigo já está eliminado");}
         }
            }
            else{Console.WriteLine("Mana insuficiente para desferir ataque!");}
         } 

         public void RestoreMP(Player friend){
             if(this.MagicPoints > 30){
             Console.WriteLine($"{this.Name} restaurou/aumentou para +{friend.MagicPoints+75} de mana do {friend.Name}");
             this.MagicPoints=this.MagicPoints-15;
             }
             else{Console.WriteLine("Mana insuficiente para usar magia");}
         }
         public override void Defend(Enemy monster){
             if(this.MagicPoints >= 65){
             Console.WriteLine($"{this.Name} usou campo de força contra os ataque de {monster.Name}");
             this.MagicPoints = this.MagicPoints-65;
         }
            else{Console.WriteLine("Mana insuficiente para a defesa!");}
         }
    }
    
}