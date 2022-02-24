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
        public Character Create_Vampire(string nam){
            Vampire vampiro = new Vampire();
            vampiro.Name = nam;
            return vampiro;
        }
        public Character Create_Hollow(string nam){
           Hollow hollow = new Hollow();
           hollow.Name = nam;
           return hollow;
        }        
        public Character Create_Zombie(string nam){
            Zombie zumbi = new Zombie();
            zumbi.Name = nam;
            return zumbi;
        }
        public Character Create_Hunter(string nam){
            Hunter caçador = new Hunter();
            caçador.Name = nam;
            return caçador;
        }
        }
}