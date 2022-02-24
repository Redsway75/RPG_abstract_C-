using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class Interface
    {
        static void Main(String[] args){

            Cinterface inter = new Cinterface();
            List<Character> list_ = new List<Character>();
                       
            while(true){

                Console.WriteLine("Digite uma opção:");
                Console.WriteLine("1- Criar personagem (Player)");
                Console.WriteLine("2- Criar personagem (Inimigo)");
                Console.WriteLine("3- Jogar");
                Console.WriteLine("4- Listar todos os personagens criados");
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
                                list_.Add(inter.Create_Thief(lname, lguild));
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
                                inter.Create_Knight(name_, guild_);
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
                                list_.Add(inter.Create_Thief(dname, dguild));
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
                                list_.Add(inter.Create_Vampire(vname));
                                Console.Clear();
                                Console.WriteLine("Personagem do tipo vampiro criado");
                            break;
                            case 2:
                                Console.WriteLine("Nome: ");
                                string zname = Console.ReadLine();
                                #nullable disable

                                inter.Create_Zombie(zname);
                                list_.Add(inter.Create_Zombie(zname));
                                Console.Clear();
                                Console.WriteLine("Personagem do tipo zumbi criado");
                            break;
                            case 3:
                                Console.WriteLine("Nome: ");
                                string hname = Console.ReadLine();
                                #nullable disable

                                inter.Create_Hollow(hname);
                                list_.Add(inter.Create_Hollow(hname));
                                Console.Clear();
                                Console.WriteLine("Personagem do tipo hollow criado");
                            break;
                            case 4:
                                Console.WriteLine("Nome: ");
                                string cname = Console.ReadLine();
                                #nullable disable

                                inter.Create_Hunter(cname);
                                list_.Add(inter.Create_Hunter(cname));
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
                        
                    break;

                    case 4:
                        if(list_.Any()){
                            Console.Clear();
                            foreach (var ListChar in list_){
                                Console.WriteLine(ListChar.Name+"level "+ ListChar.Level+" ");
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