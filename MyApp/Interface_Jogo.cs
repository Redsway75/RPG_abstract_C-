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
            List<Character> list_ = new List<Character>();
            Player[] static_p = new Player[1];
            Enemy[] static_e = new Enemy[1];

            int i=0;
            int j = 0;

            while(true){
                menu:
                Console.WriteLine("Digite uma opção:");
                Console.WriteLine("1- Criar personagem (Player)");
                Console.WriteLine("2- Criar personagem (Inimigo)");
                Console.WriteLine("3- Jogar");
                Console.WriteLine("4- Listar personagens criados");
                Console.WriteLine("5- Sair");
                #nullable disable
                int option = int.Parse(Console.ReadLine());
        
                switch(option){
                    

                    case 1:
                        if(i!=0){
                            Console.Clear();
                            Console.WriteLine("O limite para criar personagem é de 1 player e 1 inimigo!!!");
                            goto menu;
                        }     
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
                                list_.Add(inter.Create_Knight(cname, cguild));
                                static_p[0] = inter.Create_Knight(cname, cguild);
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
                                static_p[0] = inter.Create_Thief(lname, lguild);
                                list_.Add(inter.Create_Thief(lname, lguild));
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
                                static_p[0] = inter.Create_Witcher(name_, guild_);
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
                                static_p[0] = inter.Create_Divine(dname, dguild);
                                list_.Add(inter.Create_Divine(dname, dguild));
                                Console.Clear();
                                Console.WriteLine("Personagem de classe divino criado");
                                i++;
                           break;
                           case 5:
                                 Console.Clear();
                           goto menu;
                           default:
                               Console.Clear(); 
                               Console.WriteLine("Comando invalido!");
                           break;
                        }

                    break;

                    case 2:
                        if(j!=0){
                            Console.Clear();
                            Console.WriteLine("O limite para criar personagem é de 1 player e 1 inimigo!!!");
                            goto menu;
                        } 
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
                                static_e[0] = inter.Create_Vampire(vname);
                                list_.Add(inter.Create_Vampire(vname));
                                Console.Clear();
                                Console.WriteLine("Personagem do tipo vampiro criado");
                                j++;
                            break;
                            case 2:
                                Console.WriteLine("Nome: ");
                                string zname = Console.ReadLine();
                                #nullable disable

                                inter.Create_Zombie(zname);
                                static_e[0] = inter.Create_Zombie(zname);
                                list_.Add(inter.Create_Zombie(zname));
                                Console.Clear();
                                Console.WriteLine("Personagem do tipo zumbi criado");
                                j++;
                            break;
                            case 3:
                                Console.WriteLine("Nome: ");
                                string hname = Console.ReadLine();
                                #nullable disable

                                inter.Create_Hollow(hname);
                                static_e[0] = inter.Create_Hollow(hname);
                                list_.Add(inter.Create_Hollow(hname));
                                Console.Clear();
                                Console.WriteLine("Personagem do tipo hollow criado");
                                j++;
                            break;
                            case 4:
                                Console.WriteLine("Nome: ");
                                string cname = Console.ReadLine();
                                #nullable disable

                                inter.Create_Hunter(cname);
                                static_e[0] = inter.Create_Hunter(cname);
                                list_.Add(inter.Create_Hunter(cname));
                                Console.Clear();
                                Console.WriteLine("Personagem do tipo vampiro criado");
                                j++;
                            break;
                            case 5:
                                Console.Clear();
                            goto menu;
                            default:
                                Console.Clear();
                                Console.WriteLine("Digite uma opção valida!");
                            break;
                        }
                    break;

                    case 3:
                        Console.Clear();
                        if(static_p[0] == null | static_e[0] == null){Console.WriteLine("É NECESSÁRIO CRIAR UM PLAYER E UM INIMIGO PARA JOGAR!");}
                        else{
                        while(true){
                            int a;
                            inter.CharStatus(static_p[0], static_e[0]);
                            Console.WriteLine("Digite uma opção para que ambos executem:");
                            Console.WriteLine("0- Sair");
                            Console.WriteLine("1- Atacar");
                            Console.WriteLine("2- Ataque Especial");
                            Console.WriteLine("3- Skill");
                            Console.WriteLine("4- Defender");
                            
                            a = int.Parse(Console.ReadLine());

                            inter.batalha(static_p[0], static_e[0], a);

                            if(static_p[0].HP <=0 | static_e[0].HP <= 0| a == 0){Console.WriteLine("FIM DO JOGO!");break;}
                        }
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
                             else{Console.Clear();Console.WriteLine("Lista vazia!!! Crie 1 personagem de cada!!!");}
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