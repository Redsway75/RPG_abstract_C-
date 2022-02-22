namespace MyApp
{
    public class Cinterface
    {
        private Character start;
        public Cinterface(){
            this.start = null;
        }
        public void Create_Knight(string nam, string gui){
              Knight cavaleiro = new Knight();
              cavaleiro.Name = nam;
              cavaleiro.Guild = gui;
              cavaleiro.NullPointer = null;

              if(start == null){start = cavaleiro;}
              else{
                 Character aux;
                 aux = start;
                 while(aux.NullPointer != null){
                    aux = aux.NullPointer;
                      }
                        aux.NullPointer = cavaleiro;
                    }  
             }
        public void Create_Thief(string nam, string gui){
            Thief ladrao = new Thief();
            ladrao.Name = nam;
            ladrao.Guild = gui;
            ladrao.NullPointer = null;

            if(start == null){start = ladrao;}
              else{
                 Character aux;
                 aux = start;
                 while(aux.NullPointer != null){
                    aux = aux.NullPointer;
                      }
                        aux.NullPointer = ladrao;
                    }  
        }
          public void Create_Divine(string nam, string gui){
            Divine clerigo = new Divine();
            clerigo.Name = nam;
            clerigo.Guild = gui;
            clerigo.NullPointer = null;

            if(start == null){start = clerigo;}
              else{
                 Character aux;
                 aux = start;
                 while(aux.NullPointer != null){
                    aux = aux.NullPointer;
                      }
                        aux.NullPointer = clerigo;
                    }  
        }
        public void Create_Witcher(string nam, string gui){
            Witcher bruxo = new Witcher();
            bruxo.Name = nam;
            bruxo.Guild = gui;
            bruxo.NullPointer = null;

            if(start == null){start = bruxo;}
              else{
                 Character aux;
                 aux = start;
                 while(aux.NullPointer != null){
                    aux = aux.NullPointer;
                      }
                        aux.NullPointer = bruxo;
                    }  
        }
        public void List_char(){
            if(start == null){Console.WriteLine("Nenhum personagem criado para listar!");}
            else{
                Character aux = start;
                while(aux != null){
                    Console.WriteLine("Personagem: "+aux.Name);
                    aux = aux.NullPointer;
                }
            }
        }
        }
        }