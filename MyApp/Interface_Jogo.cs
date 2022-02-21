
namespace MyApp
{
    public class Interface
    {
        static void Main(String[] args){
            
            

            while(true){

                Console.WriteLine("Digite uma opção:");
                Console.WriteLine("1- Criar personagem (Player)");
                Console.WriteLine("2- Criar Npc");
                Console.WriteLine("3- Jogar");
                Console.WriteLine("4- Sair");

                int option; 
                option = int.Parse(Console.ReadLine());

                switch(option){
                    

                    case 1:                    
                        Console.WriteLine("Escolha uma classe e nomei");
                        Console.WriteLine("1- Knight");
                        Console.WriteLine("2- Thief");
                        Console.WriteLine("3- Witcher");
                        Console.WriteLine("4- Divine");
                        Console.WriteLine("5- Cancelar");
                        int new_char = int.Parse(Console.ReadLine());
                        
                        switch(new_char){
                           case 1:
                                Console.WriteLine("Nome:");
                                Console.ReadLine();

                                Console.WriteLine(":");
                                Console.ReadLine();

                                Console.WriteLine("Nome:");
                                Console.ReadLine();

                                Console.WriteLine("Nome:");
                                Console.ReadLine();

                                Console.WriteLine("Nome:");
                                Console.ReadLine();
                           break;
                           case 2:
                           break;
                           case 3:
                           break;
                           case 4:
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