namespace MyApp
{
    public class Knight: Player
    {
        public override void Attack(Enemy monster){
            if(monster.HP>0){
            Console.WriteLine(this.Name+" Desferiu um ataque com a sua espada no " +monster.Name);
             monster.HP = monster.HP - 35;
             this.MagicPoints=this.MagicPoints+20;
                if(monster.HP <= 0){Console.WriteLine(this.Name+"Matou "+monster.Name);}
                this.MagicPoints=this.MagicPoints+35;
            }
             else{Console.WriteLine("O inimigo já está eliminado");}
         }
         
         public override void SpecialAttack(Enemy monster){
            if(this.MagicPoints >= 75){
             if(monster.HP != 0){
             Console.WriteLine(this.Name+" ativou o modo berseker e foi para cima de "+monster.Name);
             monster.HP = monster.HP - 70;
             this.MagicPoints=this.MagicPoints-75;
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
         public void Bomb(Enemy monster){
             if(this.MagicPoints >= 45){
                 if(monster.HP > 0 ){
                    Console.WriteLine($"{this.Name} lançõu bomba no {monster.Name}");
                    monster.HP = monster.HP - 35;
                    this.MagicPoints = this.MagicPoints-45;
                        if(monster.HP <=0){
                            Console.WriteLine($"{this.Name} matou {monster.Name}!");
                            this.MagicPoints = this.MagicPoints-55;
                            this.Level = this.Level+1;
                        }
         }
                else{Console.WriteLine("O inimigo está eliminado!");}
         }
            else{Console.WriteLine("Mana insuficiente!!!");}
         }
         public override void Defend(Enemy monster){
            if(this.MagicPoints>=15){
             Console.WriteLine($"{this.Name} se defendeu desviando dos ataques de {monster.Name}");
             this.MagicPoints=this.MagicPoints-15;
         }
            else{Console.WriteLine("Mana insuficiente para se defender!");}
         }
    }  
    }