namespace Intech.Ferramentas.Controles.Conexoes
{
    partial class Conexoes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonAtualizarBancos = new System.Windows.Forms.Button();
            this.ComboBoxBanco = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxSenha = new System.Windows.Forms.TextBox();
            this.TextBoxUsuario = new System.Windows.Forms.TextBox();
            this.ComboBoxServidor = new System.Windows.Forms.ComboBox();
            this.ComboBoxProvedor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBoxSistema = new System.Windows.Forms.ComboBox();
            this.sistemaEntidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonExcluir = new System.Windows.Forms.Button();
            this.ButtonSalvar = new System.Windows.Forms.Button();
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListConexoes = new System.Windows.Forms.ListBox();
            this.ButtonNovo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaEntidadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ButtonAtualizarBancos);
            this.groupBox1.Controls.Add(this.ComboBoxBanco);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TextBoxSenha);
            this.groupBox1.Controls.Add(this.TextBoxUsuario);
            this.groupBox1.Controls.Add(this.ComboBoxServidor);
            this.groupBox1.Controls.Add(this.ComboBoxProvedor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ComboBoxSistema);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ButtonExcluir);
            this.groupBox1.Controls.Add(this.ButtonSalvar);
            this.groupBox1.Controls.Add(this.TextBoxNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(238, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(740, 570);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parâmetros";
            // 
            // ButtonAtualizarBancos
            // 
            this.ButtonAtualizarBancos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAtualizarBancos.BackColor = System.Drawing.Color.Gold;
            this.ButtonAtualizarBancos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAtualizarBancos.FlatAppearance.BorderSize = 0;
            this.ButtonAtualizarBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAtualizarBancos.Location = new System.Drawing.Point(703, 353);
            this.ButtonAtualizarBancos.Name = "ButtonAtualizarBancos";
            this.ButtonAtualizarBancos.Size = new System.Drawing.Size(31, 22);
            this.ButtonAtualizarBancos.TabIndex = 26;
            this.ButtonAtualizarBancos.UseVisualStyleBackColor = false;
            this.ButtonAtualizarBancos.Click += new System.EventHandler(this.ButtonAtualizarBancos_Click);
            // 
            // ComboBoxBanco
            // 
            this.ComboBoxBanco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxBanco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxBanco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxBanco.BackColor = System.Drawing.SystemColors.Window;
            this.ComboBoxBanco.FormattingEnabled = true;
            this.ComboBoxBanco.Location = new System.Drawing.Point(7, 352);
            this.ComboBoxBanco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxBanco.Name = "ComboBoxBanco";
            this.ComboBoxBanco.Size = new System.Drawing.Size(690, 24);
            this.ComboBoxBanco.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Banco";
            // 
            // TextBoxSenha
            // 
            this.TextBoxSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSenha.Location = new System.Drawing.Point(7, 290);
            this.TextBoxSenha.Name = "TextBoxSenha";
            this.TextBoxSenha.Size = new System.Drawing.Size(727, 22);
            this.TextBoxSenha.TabIndex = 4;
            this.TextBoxSenha.Text = "masterkey";
            // 
            // TextBoxUsuario
            // 
            this.TextBoxUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxUsuario.Location = new System.Drawing.Point(7, 227);
            this.TextBoxUsuario.Name = "TextBoxUsuario";
            this.TextBoxUsuario.Size = new System.Drawing.Size(727, 22);
            this.TextBoxUsuario.TabIndex = 3;
            this.TextBoxUsuario.Text = "sysdba";
            // 
            // ComboBoxServidor
            // 
            this.ComboBoxServidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxServidor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxServidor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxServidor.BackColor = System.Drawing.SystemColors.Window;
            this.ComboBoxServidor.FormattingEnabled = true;
            this.ComboBoxServidor.Items.AddRange(new object[] {
            "10.10.170.39",
            "10.10.170.13",
            "localhost"});
            this.ComboBoxServidor.Location = new System.Drawing.Point(7, 164);
            this.ComboBoxServidor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxServidor.Name = "ComboBoxServidor";
            this.ComboBoxServidor.Size = new System.Drawing.Size(727, 24);
            this.ComboBoxServidor.TabIndex = 2;
            // 
            // ComboBoxProvedor
            // 
            this.ComboBoxProvedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxProvedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxProvedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxProvedor.BackColor = System.Drawing.SystemColors.Window;
            this.ComboBoxProvedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxProvedor.FormattingEnabled = true;
            this.ComboBoxProvedor.Items.AddRange(new object[] {
            "sqlserver"});
            this.ComboBoxProvedor.Location = new System.Drawing.Point(7, 103);
            this.ComboBoxProvedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxProvedor.Name = "ComboBoxProvedor";
            this.ComboBoxProvedor.Size = new System.Drawing.Size(727, 24);
            this.ComboBoxProvedor.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Usuário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Sistema";
            // 
            // ComboBoxSistema
            // 
            this.ComboBoxSistema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxSistema.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxSistema.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxSistema.BackColor = System.Drawing.SystemColors.Window;
            this.ComboBoxSistema.DataSource = this.sistemaEntidadeBindingSource;
            this.ComboBoxSistema.DisplayMember = "NOM_SISTEMA";
            this.ComboBoxSistema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSistema.FormattingEnabled = true;
            this.ComboBoxSistema.Location = new System.Drawing.Point(7, 413);
            this.ComboBoxSistema.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxSistema.Name = "ComboBoxSistema";
            this.ComboBoxSistema.Size = new System.Drawing.Size(727, 24);
            this.ComboBoxSistema.TabIndex = 5;
            this.ComboBoxSistema.ValueMember = "OID_SISTEMA";
            // 
            // sistemaEntidadeBindingSource
            // 
            this.sistemaEntidadeBindingSource.DataSource = typeof(Intech.Ferramentas.Dados.Entidades.SistemaEntidade);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Provedor";
            // 
            // ButtonExcluir
            // 
            this.ButtonExcluir.BackColor = System.Drawing.Color.Coral;
            this.ButtonExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonExcluir.FlatAppearance.BorderSize = 0;
            this.ButtonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExcluir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonExcluir.Location = new System.Drawing.Point(125, 532);
            this.ButtonExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonExcluir.Name = "ButtonExcluir";
            this.ButtonExcluir.Size = new System.Drawing.Size(113, 30);
            this.ButtonExcluir.TabIndex = 7;
            this.ButtonExcluir.Text = "Excluir";
            this.ButtonExcluir.UseVisualStyleBackColor = false;
            this.ButtonExcluir.Click += new System.EventHandler(this.ButtonExcluir_Click);
            // 
            // ButtonSalvar
            // 
            this.ButtonSalvar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSalvar.FlatAppearance.BorderSize = 0;
            this.ButtonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSalvar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonSalvar.Location = new System.Drawing.Point(6, 532);
            this.ButtonSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonSalvar.Name = "ButtonSalvar";
            this.ButtonSalvar.Size = new System.Drawing.Size(113, 30);
            this.ButtonSalvar.TabIndex = 6;
            this.ButtonSalvar.Text = "Salvar";
            this.ButtonSalvar.UseVisualStyleBackColor = false;
            this.ButtonSalvar.Click += new System.EventHandler(this.ButtonSalvar_Click);
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxNome.Location = new System.Drawing.Point(7, 47);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(727, 22);
            this.TextBoxNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // ListConexoes
            // 
            this.ListConexoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListConexoes.DisplayMember = "NOME";
            this.ListConexoes.FormattingEnabled = true;
            this.ListConexoes.ItemHeight = 16;
            this.ListConexoes.Location = new System.Drawing.Point(3, 44);
            this.ListConexoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListConexoes.Name = "ListConexoes";
            this.ListConexoes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListConexoes.Size = new System.Drawing.Size(229, 564);
            this.ListConexoes.TabIndex = 16;
            this.ListConexoes.SelectedIndexChanged += new System.EventHandler(this.ListConexoes_SelectedIndexChanged);
            // 
            // ButtonNovo
            // 
            this.ButtonNovo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNovo.FlatAppearance.BorderSize = 0;
            this.ButtonNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNovo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonNovo.Location = new System.Drawing.Point(3, 6);
            this.ButtonNovo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonNovo.Name = "ButtonNovo";
            this.ButtonNovo.Size = new System.Drawing.Size(229, 30);
            this.ButtonNovo.TabIndex = 17;
            this.ButtonNovo.Text = "Novo";
            this.ButtonNovo.UseVisualStyleBackColor = false;
            this.ButtonNovo.Click += new System.EventHandler(this.ButtonNovo_Click);
            // 
            // Conexoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListConexoes);
            this.Controls.Add(this.ButtonNovo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Conexoes";
            this.Size = new System.Drawing.Size(981, 613);
            this.Load += new System.EventHandler(this.Conexoes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaEntidadeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonExcluir;
        private System.Windows.Forms.Button ButtonSalvar;
        private System.Windows.Forms.TextBox TextBoxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListConexoes;
        private System.Windows.Forms.Button ButtonNovo;
        private System.Windows.Forms.ComboBox ComboBoxServidor;
        private System.Windows.Forms.ComboBox ComboBoxProvedor;
        private System.Windows.Forms.ComboBox ComboBoxSistema;
        private System.Windows.Forms.TextBox TextBoxSenha;
        private System.Windows.Forms.TextBox TextBoxUsuario;
        private System.Windows.Forms.BindingSource sistemaEntidadeBindingSource;
        private System.Windows.Forms.ComboBox ComboBoxBanco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ButtonAtualizarBancos;
    }
}
