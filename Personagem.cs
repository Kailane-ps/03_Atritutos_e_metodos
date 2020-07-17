using System;

namespace Atritutos_e_metodos_03
{
    public class Personagem
    {
        
        public string Nome = "Itachi Uchiha";
        public string Cla = "Uchiha";
        public string Ocupacao;
        public bool vivo;
    

        public string Atacar()
        {
            return "O personagem usou um Jutsu!";
        }

        public string estadoo (){
            vivo = false;
            return "Estado: Morto";
        }
    }
}