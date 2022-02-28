namespace MyApp
{
    public class Cinterface
    {
        
        public Knight Create_Knight(string nam, string gui){
              Knight cavaleiro = new Knight();
              cavaleiro.Name = nam;
              cavaleiro.Guild = gui;
              return cavaleiro;
             }
             
        public Thief Create_Thief(string nam, string gui){
            Thief ladrao = new Thief();
            ladrao.Name = nam;
            ladrao.Guild = gui;
            return ladrao;
        }
          public Divine Create_Divine(string nam, string gui){
            Divine clerigo = new Divine();
            clerigo.Name = nam;
            clerigo.Guild = gui; 
            return clerigo;
        }
        public Witcher Create_Witcher(string nam, string gui){
            Witcher bruxo = new Witcher();
            bruxo.Name = nam;
            bruxo.Guild = gui; 
            return bruxo;
        }
        public Vampire Create_Vampire(string nam){
            Vampire vampiro = new Vampire();
            vampiro.Name = nam;
            return vampiro;
        }
        public Hollow Create_Hollow(string nam){
           Hollow hollow = new Hollow();
           hollow.Name = nam;
           return hollow;
        }        
        public Zombie Create_Zombie(string nam){
            Zombie zumbi = new Zombie();
            zumbi.Name = nam;
            return zumbi;
        }
        public Hunter Create_Hunter(string nam){
            Hunter caçador = new Hunter();
            caçador.Name = nam;
            return caçador;
        }

        public void read(int num1, int num2){
            int num = num1;
            int numb = num2;            
            Console.WriteLine("Digite o ID do Player:");
            #nullable disable
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ID do Inimigo:");
            numb = int.Parse(Console.ReadLine());
            
        }
        public void CharStatus(Player char1, Enemy char2){
            Console.WriteLine("");
            if(char1.HP>0 | char2.HP>0){
                Console.WriteLine("Começando um novo turno...");
            }
            else{Console.WriteLine("FIM DA PARTIDA");}
            Console.WriteLine("");
            Console.WriteLine("Status do turno atual:");
            Console.WriteLine($"{char1.Name} -> VIDA:{char1.HP} MANA:{char1.MagicPoints} DINHEIRO:{char1.Coin}");
            Console.WriteLine($"{char2.Name} -> VIDA:{char2.HP} MANA:{char2.MagicPoints} DINHEIRO:{char2.Coin}");
            Console.WriteLine("------------------------------------------------------------------------------");
            
        }
        public void batalha(Player player, Enemy enemy, int choose){
        
            /*while(player.HP>0 | enemy.HP>0 | choose != 0){
            CharStatus(player, enemy);
            Console.WriteLine("Digite uma opção para que ambos executem:");
            Console.WriteLine("0- Sair");
            Console.WriteLine("1- Atacar");
            Console.WriteLine("2- Ataque Especial");
            Console.WriteLine("3- Skill");
            Console.WriteLine("4- Defender");
            Console.WriteLine("5- Skip");*/
            
                switch(choose){
                    case 0:

                        Console.Clear();
                        Console.WriteLine("Voltando para o MENU...");
                    break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("");
                        if(player.HP>0){
                            player.Attack(enemy);
                                if(enemy.HP<=0){
                                    Console.WriteLine("");
                                    Console.WriteLine($"{player.Name} venceu a batalha"); 
                                    Environment.Exit(0);}
                        }
                        if(enemy.HP>0){
                            enemy.Attack(player);
                                if(player.HP<=0){
                                    Console.WriteLine("");
                                    Console.WriteLine($"{enemy.Name} venceu a batalha!");
                                    Environment.Exit(0);
                             }
                        }
                    break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("");
                        if(player.HP>0){
                            player.SpecialAttack(enemy);
                                if(enemy.HP<=0){
                                    Console.WriteLine("");
                                    Console.WriteLine($"{player.Name} venceu a batalha");
                                    Environment.Exit(0);}
                        }
                        if(enemy.HP>0){
                            enemy.SpecialAttack(player); 
                                if(player.HP<=0){
                                    Console.WriteLine("");
                                    Console.WriteLine($"{enemy.Name} venceu a batalha!");
                                    Environment.Exit(0);}
                        }
                    break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("");
                            if(enemy.HP>0){
                                enemy.skill(player);
                                    if(player.HP<=0){
                                        Console.WriteLine("");
                                        Console.WriteLine($"{enemy.Name} venceu a batalha!");
                                        Environment.Exit(0);}
                        }
                            if(player.HP>0){
                                player.skill(enemy);
                                    if(enemy.HP<=0){
                                        Console.WriteLine("");
                                        Console.WriteLine($"{player.Name} venceu a batalha");
                                        Environment.Exit(0);}
                        }
                    break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("");
                        if(player.HP>0){
                            player.Defend(enemy);
                                if(player.HP<=0){
                                    Console.WriteLine("");
                                    Console.WriteLine($"{player.Name} venceu a batalha!");
                                    Environment.Exit(0);}
                        }
                        if(enemy.HP>0)
                            enemy.Defend(player);
                                if(enemy.HP<=0){
                                    Console.WriteLine("");
                                    Console.WriteLine($"{enemy.Name} venceu a batalha");
                                    Environment.Exit(0);}
                    break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Digite um valor válido");
                    break;
                }
            }
        }
        }
