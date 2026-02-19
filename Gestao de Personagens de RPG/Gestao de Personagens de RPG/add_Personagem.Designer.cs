namespace Gestao_de_Personagens_de_RPG
{
    partial class add_Personagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txt_Nome = new TextBox();
            lb_Classe = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cmb_Classe = new ComboBox();
            label7 = new Label();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            btn_Salvar = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            lb_Vida = new Label();
            nud_Vida = new NumericUpDown();
            lb_Level = new Label();
            nud_Level = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Vida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Level).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 36);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "NOME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(450, 36);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 1;
            label2.Text = "DATA DE NASCIMENTO";
            // 
            // txt_Nome
            // 
            txt_Nome.Location = new Point(165, 36);
            txt_Nome.Name = "txt_Nome";
            txt_Nome.Size = new Size(195, 23);
            txt_Nome.TabIndex = 2;
            // 
            // lb_Classe
            // 
            lb_Classe.AutoSize = true;
            lb_Classe.Location = new Point(78, 86);
            lb_Classe.Name = "lb_Classe";
            lb_Classe.Size = new Size(47, 15);
            lb_Classe.TabIndex = 4;
            lb_Classe.Text = "CLASSE";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // cmb_Classe
            // 
            cmb_Classe.FormattingEnabled = true;
            cmb_Classe.Location = new Point(165, 83);
            cmb_Classe.Name = "cmb_Classe";
            cmb_Classe.Size = new Size(195, 23);
            cmb_Classe.TabIndex = 14;
            cmb_Classe.SelectedIndexChanged += cmb_Classe_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(476, 83);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 15;
            label7.Text = "SEXO";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(559, 80);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(195, 23);
            comboBox2.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(601, 28);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(108, 23);
            dateTimePicker1.TabIndex = 21;
            // 
            // btn_Salvar
            // 
            btn_Salvar.Location = new Point(476, 322);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(105, 46);
            btn_Salvar.TabIndex = 23;
            btn_Salvar.Text = "CRIAR";
            btn_Salvar.UseVisualStyleBackColor = true;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(255, 322);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 46);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lb_Vida
            // 
            lb_Vida.AutoSize = true;
            lb_Vida.Location = new Point(87, 141);
            lb_Vida.Name = "lb_Vida";
            lb_Vida.Size = new Size(33, 15);
            lb_Vida.TabIndex = 25;
            lb_Vida.Text = "VIDA";
            // 
            // nud_Vida
            // 
            nud_Vida.Location = new Point(165, 133);
            nud_Vida.Name = "nud_Vida";
            nud_Vida.Size = new Size(120, 23);
            nud_Vida.TabIndex = 26;
            nud_Vida.ValueChanged += nud_Vida_ValueChanged;
            // 
            // lb_Level
            // 
            lb_Level.AutoSize = true;
            lb_Level.Location = new Point(87, 185);
            lb_Level.Name = "lb_Level";
            lb_Level.Size = new Size(38, 15);
            lb_Level.TabIndex = 27;
            lb_Level.Text = "LEVEL";
            // 
            // nud_Level
            // 
            nud_Level.Location = new Point(165, 177);
            nud_Level.Name = "nud_Level";
            nud_Level.Size = new Size(120, 23);
            nud_Level.TabIndex = 28;
            // 
            // add_Personagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nud_Level);
            Controls.Add(lb_Level);
            Controls.Add(nud_Vida);
            Controls.Add(lb_Vida);
            Controls.Add(btnCancelar);
            Controls.Add(btn_Salvar);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(cmb_Classe);
            Controls.Add(lb_Classe);
            Controls.Add(txt_Nome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "add_Personagem";
            Text = "add_Personagem";
            Load += add_Personagem_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Vida).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Level).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_Nome;
        private Label lb_Classe;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox cmb_Classe;
        private Label label7;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private Button btn_Salvar;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
        private NumericUpDown nud_Vida;
        private Label lb_Vida;
        private NumericUpDown nud_Level;
        private Label lb_Level;
    }
}