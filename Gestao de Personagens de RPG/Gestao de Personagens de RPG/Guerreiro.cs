using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_de_Personagens_de_RPG
{
    public class Guerreiro : Personagem
    {
        public Guerreiro() : base()
        {
            Classe = "Guerreiroi";
            Vida = 120;
        }
        public Guerreiro(string nome, int nivel) : base(nome, nivel)
        {
            Classe = "Guerreiro";
            Vida = 120;
        }
            

        public override double CalcularPoder()
        {
            return Vida * Nivel * 1.5;
        }
    }
}
