namespace MyApp
{
    public class Cinterface
    {
        

        public Character Create_Knight(string nam, string gui){
              Knight cavaleiro = new Knight();
              cavaleiro.Name = nam;
              cavaleiro.Guild = gui;
              return cavaleiro;
             }
             
        public Character Create_Thief(string nam, string gui){
            Thief ladrao = new Thief();
            ladrao.Name = nam;
            ladrao.Guild = gui;
            return ladrao;
        }
          public Character Create_Divine(string nam, string gui){
            Divine clerigo = new Divine();
            clerigo.Name = nam;
            clerigo.Guild = gui; 
            return clerigo;
        }
        public Character Create_Witcher(string nam, string gui){
            Witcher bruxo = new Witcher();
            bruxo.Name = nam;
            bruxo.Guild = gui; 
            return bruxo;
        }
        
        }
}