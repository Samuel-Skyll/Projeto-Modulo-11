namespace Gestao_de_Personagens_de_RPG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Jogador jogador = new Jogador();


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = jogador.LP;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            add_Personagem a = new add_Personagem();
            if (a.ShowDialog() == DialogResult.OK )
            {
                jogador.LP.Add(a.NovoPersonagem);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
