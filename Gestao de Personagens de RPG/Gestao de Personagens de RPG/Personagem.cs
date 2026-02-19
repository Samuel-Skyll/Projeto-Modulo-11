using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_de_Personagens_de_RPG
{
    public class Personagem
    {
        private static int contadorId = 1;

        public int Id { get; private set; }
        public string Nome { get; set; }
        public int Nivel { get; set; }
        public int Vida { get; set; }
        public string Classe { get; set; }

        public Personagem()
        {
            Id = contadorId++;
            Nivel = 1;
        }

        public Personagem(string nome, int nivel)
        {
            Id = contadorId++;
            Nivel = nivel;
            Nome = nome;
        }

        public virtual double CalcularPoder()
        {
            return Vida * Nivel;
        }

    }
}
