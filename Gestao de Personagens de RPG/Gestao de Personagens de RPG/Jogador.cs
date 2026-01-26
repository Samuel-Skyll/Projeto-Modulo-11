using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_de_Personagens_de_RPG
{
    public class Jogador
    {
        public string Nome;
        public string NickName;

        BindingList<Personagem> LP = new BindingList<Personagem>();
    }
}
