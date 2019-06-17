namespace Intech.Ferramentas.GeradorCodigo.Controles
{
    partial class ControleConexoes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ListBoxConexoes = new System.Windows.Forms.ListBox();
            this.conexaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonDeletar = new System.Windows.Forms.Button();
            this.ButtonSalvar = new System.Windows.Forms.Button();
            this.TextBoxBanco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxServidor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxProvider = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.conexaoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxConexoes
            // 
            this.ListBoxConexoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListBoxConexoes.DataSource = this.conexaoBindingSource;
            this.ListBoxConexoes.DisplayMember = "Database";
            this.ListBoxConexoes.FormattingEnabled = true;
            this.ListBoxConexoes.Location = new System.Drawing.Point(3, 29);
            this.ListBoxConexoes.Name = "ListBoxConexoes";
            this.ListBoxConexoes.Size = new System.Drawing.Size(173, 368);
            this.ListBoxConexoes.TabIndex = 0;
            this.ListBoxConexoes.SelectedIndexChanged += new System.EventHandler(this.ListBoxConexoes_SelectedIndexChanged);
            // 
            // conexaoBindingSource
            // 
            this.conexaoBindingSource.DataSource = typeof(Intech.Ferramentas.GeradorCodigo.Code.Conexao);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ButtonDeletar);
            this.groupBox1.Controls.Add(this.ButtonSalvar);
            this.groupBox1.Controls.Add(this.TextBoxBanco);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TextBoxSenha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TextBoxUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ComboBoxServidor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ComboBoxProvider);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(183, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 393);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parâmetros";
            // 
            // ButtonDeletar
            // 
            this.ButtonDeletar.BackColor = System.Drawing.Color.Tomato;
            this.ButtonDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeletar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonDeletar.Location = new System.Drawing.Point(87, 243);
            this.ButtonDeletar.Name = "ButtonDeletar";
            this.ButtonDeletar.Size = new System.Drawing.Size(75, 23);
            this.ButtonDeletar.TabIndex = 11;
            this.ButtonDeletar.Text = "Deletar";
            this.ButtonDeletar.UseVisualStyleBackColor = false;
            this.ButtonDeletar.Click += new System.EventHandler(this.ButtonDeletar_Click);
            // 
            // ButtonSalvar
            // 
            this.ButtonSalvar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSalvar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonSalvar.Location = new System.Drawing.Point(6, 243);
            this.ButtonSalvar.Name = "ButtonSalvar";
            this.ButtonSalvar.Size = new System.Drawing.Size(75, 23);
            this.ButtonSalvar.TabIndex = 10;
            this.ButtonSalvar.Text = "Salvar";
            this.ButtonSalvar.UseVisualStyleBackColor = false;
            this.ButtonSalvar.Click += new System.EventHandler(this.ButtonSalvar_Click);
            // 
            // TextBoxBanco
            // 
            this.TextBoxBanco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxBanco.Location = new System.Drawing.Point(6, 217);
            this.TextBoxBanco.Name = "TextBoxBanco";
            this.TextBoxBanco.Size = new System.Drawing.Size(299, 20);
            this.TextBoxBanco.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Banco";
            // 
            // TextBoxSenha
            // 
            this.TextBoxSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSenha.Location = new System.Drawing.Point(7, 174);
            this.TextBoxSenha.Name = "TextBoxSenha";
            this.TextBoxSenha.Size = new System.Drawing.Size(299, 20);
            this.TextBoxSenha.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Senha";
            // 
            // TextBoxUsuario
            // 
            this.TextBoxUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxUsuario.Location = new System.Drawing.Point(7, 131);
            this.TextBoxUsuario.Name = "TextBoxUsuario";
            this.TextBoxUsuario.Size = new System.Drawing.Size(299, 20);
            this.TextBoxUsuario.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuário";
            // 
            // ComboBoxServidor
            // 
            this.ComboBoxServidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxServidor.FormattingEnabled = true;
            this.ComboBoxServidor.Items.AddRange(new object[] {
            "10.10.170.13",
            "10.10.170.39"});
            this.ComboBoxServidor.Location = new System.Drawing.Point(7, 88);
            this.ComboBoxServidor.Name = "ComboBoxServidor";
            this.ComboBoxServidor.Size = new System.Drawing.Size(300, 21);
            this.ComboBoxServidor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Servidor";
            // 
            // ComboBoxProvider
            // 
            this.ComboBoxProvider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxProvider.Enabled = false;
            this.ComboBoxProvider.FormattingEnabled = true;
            this.ComboBoxProvider.Items.AddRange(new object[] {
            "sqlserver"});
            this.ComboBoxProvider.Location = new System.Drawing.Point(7, 42);
            this.ComboBoxProvider.Name = "ComboBoxProvider";
            this.ComboBoxProvider.Size = new System.Drawing.Size(299, 21);
            this.ComboBoxProvider.TabIndex = 1;
            this.ComboBoxProvider.Text = "sqlserver";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provedor";
            // 
            // ButtonNovo
            // 
            this.ButtonNovo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNovo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonNovo.Location = new System.Drawing.Point(3, 4);
            this.ButtonNovo.Name = "ButtonNovo";
            this.ButtonNovo.Size = new System.Drawing.Size(173, 23);
            this.ButtonNovo.TabIndex = 8;
            this.ButtonNovo.Text = "Nova";
            this.ButtonNovo.UseVisualStyleBackColor = false;
            this.ButtonNovo.Click += new System.EventHandler(this.ButtonNovo_Click);
            // 
            // ControleConexoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonNovo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListBoxConexoes);
            this.Name = "ControleConexoes";
            this.Size = new System.Drawing.Size(498, 402);
            this.Load += new System.EventHandler(this.ControleConexoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.conexaoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxConexoes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxProvider;
        private System.Windows.Forms.ComboBox ComboBoxServidor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxBanco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonDeletar;
        private System.Windows.Forms.Button ButtonSalvar;
        private System.Windows.Forms.Button ButtonNovo;
        private System.Windows.Forms.BindingSource conexaoBindingSource;
    }
}
