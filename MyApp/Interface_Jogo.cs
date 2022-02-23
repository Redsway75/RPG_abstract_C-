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
                Console.WriteLine("2- Criar Npc");
                Console.WriteLine("3- Jogar");
                Console.WriteLine("4- Listar todos os personagens criados");
                Console.WriteLine("5- Sair");

                int option; 
                option = int.Parse(Console.ReadLine());
        
                switch(option){
                    

                    case 1:                    
                        Console.WriteLine("Escolha uma classe: ");
                        Console.WriteLine("1- Knight");
                        Console.WriteLine("2- Thief");
                        Console.WriteLine("3- Witcher");
                        Console.WriteLine("4- Divine");
                        Console.WriteLine("5- Cancelar");
                        Cinterface interf = new Cinterface();
                        int new_char = int.Parse(Console.ReadLine());
                        
                        switch(new_char){
                           case 1:
                                //cavaleiro
                                Console.WriteLine("Nome: ");
                                string? cname = Console.ReadLine();
                                Console.WriteLine("Guilda");
                                string? cguild = Console.ReadLine();
                                #nullable disable
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
                                interf.Create_Divine(dname, dguild);
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