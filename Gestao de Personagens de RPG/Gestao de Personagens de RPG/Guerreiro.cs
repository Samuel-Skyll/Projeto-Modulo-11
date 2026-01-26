using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_de_Personagens_de_RPG
{
    public class Guerreiro : Personagem
    {
        public Guerreiro() 
        {
            Classe = "Guerreiro";
            Vida = 120;
            Nivel = 1;
        }
    }
}
