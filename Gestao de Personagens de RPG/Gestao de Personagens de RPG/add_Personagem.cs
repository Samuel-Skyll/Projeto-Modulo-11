using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao_de_Personagens_de_RPG
{
    public partial class add_Personagem : Form
    {
        public add_Personagem()
        {
            InitializeComponent();
        }

        public Personagem NovoPersonagem { get; private set; }





        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_Personagem_Load(object sender, EventArgs e)
        {
            cmb_Classe.Items.Add("Guerreiro");
            cmb_Classe.Items.Add("Arqueiro");

        }

        private void cmb_Classe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Classe.SelectedItem == null)
                return;

            string classe = cmb_Classe.SelectedItem.ToString();

            if (classe == "Guerreiro")
            {
                nud_Vida.Value = 120;
                nud_Level.Value = 1;
                nud_Vida.Enabled = false;
            }
            else if (classe == "Arqueiro")
            {
                nud_Vida.Value = 90;
                nud_Level.Value = 1;
                nud_Vida.Enabled = false;
            }
        }
        

        private void nud_Vida_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txt_Nome.Text))
            {
                errorProvider1.SetError(txt_Nome, "Nome Obrigatorio");
                return;
            }

            if (cmb_Classe.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmb_Classe, "Selecione uma Classe obrigatorio");
                return;
            }

            Personagem p;

            if (cmb_Classe.SelectedItem.ToString() == "Guerreiro")
                p = new Guerreiro();
            else 
                p = new Arqueiro();

            p.Nome = txt_Nome.Text;
            p.Nivel = (int) nud_Level.Value;

            NovoPersonagem = p;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
