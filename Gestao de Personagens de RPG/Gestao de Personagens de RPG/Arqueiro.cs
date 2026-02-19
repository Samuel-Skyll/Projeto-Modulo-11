using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_de_Personagens_de_RPG
{
    public class Arqueiro : Personagem
    {
        public Arqueiro() : base() 
        {
            Classe = "Arqueiro";
            Vida = 90;
        }

        public Arqueiro(string nome, int nivel) : base(nome, nivel)
        {
            Classe = "Arqueiro";
            Vida = 90;
        }

        public override double CalcularPoder()
        {
            return Vida * Nivel * 1.2;
        }
    }
}
