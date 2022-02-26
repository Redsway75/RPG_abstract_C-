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
            Knight cavaleiro = new Knight();
            Knight cavaleiro2 = new Knight();
            Vampire vampiro = new Vampire();
            Vampire vampiro2 = new Vampire();
            Thief ladrao = new Thief();
            int i = 0;
            int j = 0;

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
                                i++;
                            
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
                                i++;
                                
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
                                i++;
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
                                i++;
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
                                j++;
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
                                j++;
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
                                j++;
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
                                j++;
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
                    int battle;
                    do{
                        Console.WriteLine("");
                        Console.WriteLine("Para escolher quem irá atacar");
                        Console.WriteLine("basta seguir skipando até o char");
                        Console.WriteLine("que deseja atacar. Para o inverso,");
                        Console.WriteLine("basta executar o mesmo até o final");
                        Console.WriteLine("para que o programa pule para o próximo dalista");
                        Console.WriteLine("Escolha a opção:");
                        Console.WriteLine("1- Jogar");
                        Console.WriteLine("2- Sair");
                        battle = int.Parse(Console.ReadLine());
                        switch(battle){
                            case 1:
                                Console.Clear();
                                if(EnemyList.Any() & PlayerList.Any()){
                                    Console.Clear();
                                    Console.WriteLine("A batalha está ocorrendo agora");
                                    Console.WriteLine("Selecione uma ação ou pule para o proximo personagem!:");

                                    
                                    foreach(var lsPL in PlayerList.Select((x, y)=>new{Value = x, Index = y})){
                                        foreach(var lsIN in EnemyList.Select((z, w)=>new{Value = z, Index = w})){
                                            inter.batalha(lsPL.Value, lsIN.Value);
                                            if (lsIN.Value.HP<=0){
                                                EnemyList.Remove(lsIN.Value);
                                            }
                                            if(lsPL.Value.HP<=0){
                                                PlayerList.Remove(lsPL.Value);
                                            }
                                            else{continue;}
                                            }
                                    }                            
                                    }
                            break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Voltando para o menu...");
                            break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Digito invalido!");
                            break;
                        }
                        }while(battle !=2);
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