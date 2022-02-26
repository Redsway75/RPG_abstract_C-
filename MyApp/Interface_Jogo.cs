using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoreLinq;

namespace MyApp
{
    public class Interface
    {
        static void Main(String[] args){

            Cinterface inter = new Cinterface();
            List<Character> list_ = new List<Character>(5);
            List<Player> PlayerList = new List<Player>();
            List<Enemy> EnemyList = new List<Enemy>();
            Player cavaleiro = new Player();
            Player cavaleiro2 = new Player();
            Enemy vampiro = new Enemy();
            Enemy vampiro2 = new Enemy();
            Thief ladrao = new Thief();

            cavaleiro.Name ="andre";
            cavaleiro2.Name="nicolas";
            vampiro.Name = "Dracula";
            vampiro2.Name="blade";
            ladrao.Name="lol";

            list_.Add(cavaleiro);
            list_.Add(cavaleiro2);
            list_.Add(vampiro);
            list_.Add(vampiro2);
            list_.Add(ladrao);
            
            PlayerList.Add(cavaleiro);
            PlayerList.Add(cavaleiro2);
            EnemyList.Add(vampiro);
            EnemyList.Add(vampiro2);
            PlayerList.Add(ladrao);

            



            while(true){

                Console.WriteLine("Digite uma opção:");
                Console.WriteLine("1- Criar personagem (Player)");
                Console.WriteLine("2- Criar personagem (Inimigo)");
                Console.WriteLine("3- Jogar");
                Console.WriteLine("4- Listar pl os personagens criados");
                Console.WriteLine("5- Sair");
                #nullable disable
                int option = int.Parse(Console.ReadLine());
        
                switch(option){
                    

                    case 1:                    
                        Console.WriteLine("Escolha uma classe: ");
                        Console.WriteLine("1- Knight");
                        Console.WriteLine("2- Thief");
                        Console.WriteLine("3- Witcher");
                        Console.WriteLine("4- Divine");
                        Console.WriteLine("5- Cancelar");
                        
                        #nullable disable
                        int new_char = int.Parse(Console.ReadLine());
                        
                        switch(new_char){
                           case 1:
                                //cavaleiro
                                Console.WriteLine("Nome: ");
                                string cname = Console.ReadLine();
                                #nullable disable
                                Console.WriteLine("Guilda");
                                string cguild = Console.ReadLine();

                                inter.Create_Knight(cname, cguild);
                                PlayerList.Add(inter.Create_Knight(cname, cguild));
                                list_.Add(inter.Create_Knight(cname, cguild));
                                Console.Clear();
                                Console.WriteLine("Personagem de classe cavaleiro criado");
                            
                           break;
                           case 2:
                                //ladrao
                                Console.WriteLine("Nome: ");
                                string lname = Console.ReadLine();
                                Console.WriteLine("Guilda");
                                string lguild = Console.ReadLine();
                                #nullable disable
                                inter.Create_Thief(lname, lguild);
                                PlayerList.Add(inter.Create_Thief(lname, lguild));
                                list_.Add(inter.Create_Witcher(lname, lguild));
                                Console.Clear();
                                Console.WriteLine("Personagem de classe ladrão criado");
                           break;
                           case 3:
                                 //bruxo
                                Console.WriteLine("Nome: ");
                                string name_ = Console.ReadLine();
                                Console.WriteLine("Guilda");
                                string guild_ = Console.ReadLine();
                                #nullable disable
                                inter.Create_Witcher(name_, guild_);
                                PlayerList.Add(inter.Create_Witcher(name_, guild_));
                                list_.Add(inter.Create_Witcher(name_, guild_));
                                Console.Clear();
                                Console.WriteLine("Personagem de classe bruxo criado");
                           break;
                           case 4:
                                //divine
                                Console.WriteLine("Nome: ");
                                string dname = Console.ReadLine();
                                Console.WriteLine("Guilda");
                                string dguild = Console.ReadLine();
                                inter.Create_Divine(dname, dguild);
                                PlayerList.Add(inter.Create_Divine(dname, dguild));
                                list_.Add(inter.Create_Witcher(dname, dguild));
                                Console.Clear();
                                Console.WriteLine("Personagem de classe divino criado");
                           break;
                           case 5:
                                 Console.Clear();
                           break;
                           default:
                               Console.Clear(); 
                               Console.WriteLine("Comando invalido!");
                           break;
                        }

                    break;

                    case 2:
                        Console.WriteLine("Escolha uma inimigo: ");
                        Console.WriteLine("1- Vampire");
                        Console.WriteLine("2- Zombie");
                        Console.WriteLine("3- Hollow");
                        Console.WriteLine("4- Hunter");
                        Console.WriteLine("5- Cancelar");

                        #nullable disable
                        int new_enemy = int.Parse(Console.ReadLine());

                        switch(new_enemy){
                            case 1:
                                Console.WriteLine("Nome: ");
                                string vname = Console.ReadLine();
                                #nullable disable

                                inter.Create_Vampire(vname);
                                EnemyList.Add(inter.Create_Vampire(vname));
                                list_.AddRange(EnemyList);
                                Console.Clear();
                                Console.WriteLine("Personagem do tipo vampiro criado");
                            break;
                            case 2:
                                Console.WriteLine("Nome: ");
                                string zname = Console.ReadLine();
                                #nullable disable

                                inter.Create_Zombie(zname);
                                EnemyList.Add(inter.Create_Zombie(zname));
                                list_.AddRange(EnemyList);
                                Console.Clear();
                                Console.WriteLine("Personagem do tipo zumbi criado");
                            break;
                            case 3:
                                Console.WriteLine("Nome: ");
                                string hname = Console.ReadLine();
                                #nullable disable

                                inter.Create_Hollow(hname);
                                EnemyList.Add(inter.Create_Hollow(hname));
                                list_.AddRange(EnemyList);
                                Console.Clear();
                                Console.WriteLine("Personagem do tipo hollow criado");
                            break;
                            case 4:
                                Console.WriteLine("Nome: ");
                                string cname = Console.ReadLine();
                                #nullable disable

                                inter.Create_Hunter(cname);
                                EnemyList.Add(inter.Create_Hunter(cname));
                                list_.AddRange(EnemyList);
                                Console.Clear();
                                Console.WriteLine("Personagem do tipo vampiro criado");
                            break;
                            case 5:
                                Console.Clear();
                            break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Digite uma opção valida!");
                            break;
                        }
                    break;

                    case 3:
                        Console.WriteLine("Escolha a opção:");
                        Console.WriteLine("1- Listar ID de players");
                        Console.WriteLine("2- Listar ID de inimigos");
                        Console.WriteLine("3- Jogar");
                        Console.WriteLine("4- Sair");
                        int battle = int.Parse(Console.ReadLine());
                        switch(battle){
                            case 1:
                                if (PlayerList.Any()){
                                Console.Clear();
                                Console.WriteLine("Players: ");
                                int i=0;
                                foreach (var play in PlayerList.Select((x , y)=>new{Value = x, Index = y})){
                                    if(i<PlayerList.Count){
                                    Console.WriteLine("====================================");
                                    Console.WriteLine("====================================");
                                    Console.WriteLine($" {play.Index}- Nome:  {play.Value}");
                                    Console.WriteLine();
                                    Console.WriteLine("====================================");    
                                    }    
                                }         
                                }
                                else{Console.WriteLine("LISTA VAZIA! CRIE UM PLAYER E UM INIMIGO!");}
                            break;
                            case 2:
                                if(EnemyList.Any()){
                                    Console.Clear();
                                    Console.WriteLine("Inimigos");
                                    int j=0;
                                    foreach (var inim in EnemyList.Select((w, z)=>new{Value = w, Index = z})){
                    
                                        if(j<EnemyList.Count){
                                        Console.WriteLine("");
                                        Console.WriteLine($"{inim.Index} Nome: {inim.Value}");
                                        Console.WriteLine("");
                                        Console.WriteLine("");
                                        }
                                    }                                    
                                }
                                else{Console.WriteLine("LISTA VAZIA! CRIE UM PLAYER E UM INIMIGO!");}
                            break;
                            case 3:

                                if(EnemyList.Any() & PlayerList.Any()){
                                    Console.Clear();
                                    Console.WriteLine("Escolha seus personaegens");
                                    Console.WriteLine("Digite o ID do Player: ");
                                
                                    var listplay = new[]{PlayerList};
                                    var listini = new[]{EnemyList};

                                    var tudo = listplay.Zip(listini, (x, y)=> new{listplay = x, listini = y});
                                    foreach(var ls in tudo){

                                                    Console.WriteLine(ls.listplay+"--"+ls.listini);                
                                        
                                    }
                                    } 
                            break;
                            case 4:
                            break;
                            case 5:
                            break;
                        }
                    break;
                    case 4:
                        if(list_.Any()){
                            Console.Clear();
                            
                            foreach (var ListChar in list_){
                                
                                    Console.WriteLine("====================================");
                                    Console.WriteLine("====================================");
                                    Console.WriteLine($"NOME: {ListChar.Name} HP: {ListChar.HP}");
                                    Console.WriteLine($"MAGICPOINTS: {ListChar.MagicPoints} GOLD: {ListChar.Coin} golds");
                                    Console.WriteLine("====================================");
                                
                            }
                        }
                             else{Console.Clear();Console.WriteLine("Não existe");}
                    break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Sessão encerrada!");
                        Environment.Exit(0);
                    break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Digite uma opção válida");
                    break;
            }

        }
    }
    }
}