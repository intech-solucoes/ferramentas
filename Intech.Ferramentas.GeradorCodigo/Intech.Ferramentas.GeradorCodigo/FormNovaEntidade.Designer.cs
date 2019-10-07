namespace Intech.Ferramentas.GeradorCodigo
{
    partial class FormNovaEntidade
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxNomeEntidade = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButtonDeletar = new System.Windows.Forms.Button();
            this.ButtonAdicionar = new System.Windows.Forms.Button();
            this.CheckBoxNulo = new System.Windows.Forms.CheckBox();
            this.TextBoxTipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxNomeColuna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonNovaColuna = new System.Windows.Forms.Button();
            this.ListBoxColunasExtras = new System.Windows.Forms.ListBox();
            this.ButtonSalvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelNomeSistema = new System.Windows.Forms.Label();
            this.TextBoxNomeTabela = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckBoxSinonimo = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxChavePrimaria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CheckBoxChavePrimaria = new System.Windows.Forms.CheckBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // TextBoxNomeEntidade
            // 
            this.TextBoxNomeEntidade.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxNomeEntidade.Location = new System.Drawing.Point(13, 64);
            this.TextBoxNomeEntidade.Name = "TextBoxNomeEntidade";
            this.TextBoxNomeEntidade.Size = new System.Drawing.Size(541, 20);
            this.TextBoxNomeEntidade.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.ButtonNovaColuna);
            this.groupBox1.Controls.Add(this.ListBoxColunasExtras);
            this.groupBox1.Location = new System.Drawing.Point(13, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 216);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colunas Extras";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ButtonDeletar);
            this.groupBox2.Controls.Add(this.ButtonAdicionar);
            this.groupBox2.Controls.Add(this.CheckBoxNulo);
            this.groupBox2.Controls.Add(this.TextBoxTipo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TextBoxNomeColuna);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(186, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 193);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // ButtonDeletar
            // 
            this.ButtonDeletar.BackColor = System.Drawing.Color.Tomato;
            this.ButtonDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeletar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonDeletar.Location = new System.Drawing.Point(90, 160);
            this.ButtonDeletar.Name = "ButtonDeletar";
            this.ButtonDeletar.Size = new System.Drawing.Size(75, 23);
            this.ButtonDeletar.TabIndex = 12;
            this.ButtonDeletar.Text = "Deletar";
            this.ButtonDeletar.UseVisualStyleBackColor = false;
            this.ButtonDeletar.Click += new System.EventHandler(this.ButtonDeletar_Click);
            // 
            // ButtonAdicionar
            // 
            this.ButtonAdicionar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdicionar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonAdicionar.Location = new System.Drawing.Point(9, 160);
            this.ButtonAdicionar.Name = "ButtonAdicionar";
            this.ButtonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdicionar.TabIndex = 9;
            this.ButtonAdicionar.Text = "Adicionar";
            this.ButtonAdicionar.UseVisualStyleBackColor = false;
            this.ButtonAdicionar.Click += new System.EventHandler(this.ButtonAdicionar_Click);
            // 
            // CheckBoxNulo
            // 
            this.CheckBoxNulo.AutoSize = true;
            this.CheckBoxNulo.Location = new System.Drawing.Point(9, 121);
            this.CheckBoxNulo.Name = "CheckBoxNulo";
            this.CheckBoxNulo.Size = new System.Drawing.Size(81, 17);
            this.CheckBoxNulo.TabIndex = 8;
            this.CheckBoxNulo.Text = "Aceita Nulo";
            this.CheckBoxNulo.UseVisualStyleBackColor = true;
            // 
            // TextBoxTipo
            // 
            this.TextBoxTipo.Location = new System.Drawing.Point(7, 84);
            this.TextBoxTipo.Name = "TextBoxTipo";
            this.TextBoxTipo.Size = new System.Drawing.Size(336, 20);
            this.TextBoxTipo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo:";
            // 
            // TextBoxNomeColuna
            // 
            this.TextBoxNomeColuna.Location = new System.Drawing.Point(7, 33);
            this.TextBoxNomeColuna.Name = "TextBoxNomeColuna";
            this.TextBoxNomeColuna.Size = new System.Drawing.Size(336, 20);
            this.TextBoxNomeColuna.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // ButtonNovaColuna
            // 
            this.ButtonNovaColuna.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonNovaColuna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonNovaColuna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNovaColuna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNovaColuna.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonNovaColuna.Location = new System.Drawing.Point(6, 19);
            this.ButtonNovaColuna.Name = "ButtonNovaColuna";
            this.ButtonNovaColuna.Size = new System.Drawing.Size(174, 23);
            this.ButtonNovaColuna.TabIndex = 5;
            this.ButtonNovaColuna.Text = "Nova";
            this.ButtonNovaColuna.UseVisualStyleBackColor = false;
            this.ButtonNovaColuna.Click += new System.EventHandler(this.ButtonNovaColuna_Click);
            // 
            // ListBoxColunasExtras
            // 
            this.ListBoxColunasExtras.FormattingEnabled = true;
            this.ListBoxColunasExtras.Location = new System.Drawing.Point(6, 45);
            this.ListBoxColunasExtras.Name = "ListBoxColunasExtras";
            this.ListBoxColunasExtras.Size = new System.Drawing.Size(174, 160);
            this.ListBoxColunasExtras.TabIndex = 50;
            this.ListBoxColunasExtras.SelectedIndexChanged += new System.EventHandler(this.ListBoxColunasExtras_SelectedIndexChanged);
            // 
            // ButtonSalvar
            // 
            this.ButtonSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonSalvar.Location = new System.Drawing.Point(13, 468);
            this.ButtonSalvar.Name = "ButtonSalvar";
            this.ButtonSalvar.Size = new System.Drawing.Size(75, 23);
            this.ButtonSalvar.TabIndex = 10;
            this.ButtonSalvar.Text = "Salvar";
            this.ButtonSalvar.UseVisualStyleBackColor = true;
            this.ButtonSalvar.Click += new System.EventHandler(this.ButtonSalvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sistema:";
            // 
            // LabelNomeSistema
            // 
            this.LabelNomeSistema.AutoSize = true;
            this.LabelNomeSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomeSistema.Location = new System.Drawing.Point(99, 13);
            this.LabelNomeSistema.Name = "LabelNomeSistema";
            this.LabelNomeSistema.Size = new System.Drawing.Size(149, 24);
            this.LabelNomeSistema.TabIndex = 5;
            this.LabelNomeSistema.Text = "<nome sistema>";
            // 
            // TextBoxNomeTabela
            // 
            this.TextBoxNomeTabela.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxNomeTabela.Location = new System.Drawing.Point(13, 105);
            this.TextBoxNomeTabela.Name = "TextBoxNomeTabela";
            this.TextBoxNomeTabela.Size = new System.Drawing.Size(541, 20);
            this.TextBoxNomeTabela.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tabela:";
            // 
            // CheckBoxSinonimo
            // 
            this.CheckBoxSinonimo.AutoSize = true;
            this.CheckBoxSinonimo.Location = new System.Drawing.Point(13, 132);
            this.CheckBoxSinonimo.Name = "CheckBoxSinonimo";
            this.CheckBoxSinonimo.Size = new System.Drawing.Size(112, 17);
            this.CheckBoxSinonimo.TabIndex = 2;
            this.CheckBoxSinonimo.Text = "Tabela é sinônimo";
            this.CheckBoxSinonimo.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TextBoxChavePrimaria);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.CheckBoxChavePrimaria);
            this.groupBox3.Location = new System.Drawing.Point(13, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(541, 77);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "       Chave Primária Manual";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(331, 29);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(198, 36);
            this.label7.TabIndex = 3;
            this.label7.Text = "Utilize essa opção caso necessite indicar uma coluna para chave primária";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBoxChavePrimaria
            // 
            this.TextBoxChavePrimaria.Enabled = false;
            this.TextBoxChavePrimaria.Location = new System.Drawing.Point(6, 42);
            this.TextBoxChavePrimaria.Name = "TextBoxChavePrimaria";
            this.TextBoxChavePrimaria.Size = new System.Drawing.Size(319, 20);
            this.TextBoxChavePrimaria.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nome Chave Primária";
            // 
            // CheckBoxChavePrimaria
            // 
            this.CheckBoxChavePrimaria.AutoSize = true;
            this.CheckBoxChavePrimaria.Location = new System.Drawing.Point(12, 0);
            this.CheckBoxChavePrimaria.Name = "CheckBoxChavePrimaria";
            this.CheckBoxChavePrimaria.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxChavePrimaria.TabIndex = 3;
            this.CheckBoxChavePrimaria.UseVisualStyleBackColor = true;
            this.CheckBoxChavePrimaria.CheckedChanged += new System.EventHandler(this.CheckBoxChavePrimaria_CheckedChanged);
            // 
            // FormNovaEntidade
            // 
            this.AcceptButton = this.ButtonSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 503);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.CheckBoxSinonimo);
            this.Controls.Add(this.TextBoxNomeTabela);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LabelNomeSistema);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TextBoxNomeEntidade);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormNovaEntidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nova Entidade";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxNomeEntidade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ListBoxColunasExtras;
        private System.Windows.Forms.Button ButtonNovaColuna;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox CheckBoxNulo;
        private System.Windows.Forms.TextBox TextBoxTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxNomeColuna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonSalvar;
        private System.Windows.Forms.Button ButtonAdicionar;
        private System.Windows.Forms.Button ButtonDeletar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelNomeSistema;
        private System.Windows.Forms.TextBox TextBoxNomeTabela;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CheckBoxSinonimo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxChavePrimaria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CheckBoxChavePrimaria;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}