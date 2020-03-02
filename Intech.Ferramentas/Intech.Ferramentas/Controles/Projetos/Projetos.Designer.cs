namespace Intech.Ferramentas.Controles.Projetos
{
    partial class Projetos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboBoxSistema = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBoxProjetoAPI = new System.Windows.Forms.ComboBox();
            this.TextBoxNamespace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonProcurarDiretorio = new System.Windows.Forms.Button();
            this.TextBoxDiretorio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonExcluir = new System.Windows.Forms.Button();
            this.ButtonSalvar = new System.Windows.Forms.Button();
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListProjetos = new System.Windows.Forms.ListBox();
            this.ButtonNovo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ComboBoxSistema);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ComboBoxTipo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ComboBoxProjetoAPI);
            this.groupBox1.Controls.Add(this.TextBoxNamespace);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ButtonProcurarDiretorio);
            this.groupBox1.Controls.Add(this.TextBoxDiretorio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ButtonExcluir);
            this.groupBox1.Controls.Add(this.ButtonSalvar);
            this.groupBox1.Controls.Add(this.TextBoxNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(238, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(740, 570);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parâmetros";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Sistema";
            // 
            // ComboBoxSistema
            // 
            this.ComboBoxSistema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxSistema.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxSistema.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxSistema.BackColor = System.Drawing.SystemColors.Window;
            this.ComboBoxSistema.DisplayMember = "NOM_SISTEMA";
            this.ComboBoxSistema.FormattingEnabled = true;
            this.ComboBoxSistema.Location = new System.Drawing.Point(7, 291);
            this.ComboBoxSistema.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxSistema.Name = "ComboBoxSistema";
            this.ComboBoxSistema.Size = new System.Drawing.Size(727, 25);
            this.ComboBoxSistema.TabIndex = 4;
            this.ComboBoxSistema.ValueMember = "OID_SISTEMA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tipo";
            // 
            // ComboBoxTipo
            // 
            this.ComboBoxTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxTipo.BackColor = System.Drawing.SystemColors.Window;
            this.ComboBoxTipo.FormattingEnabled = true;
            this.ComboBoxTipo.Items.AddRange(new object[] {
            "API",
            "Mobile",
            "Web"});
            this.ComboBoxTipo.Location = new System.Drawing.Point(7, 228);
            this.ComboBoxTipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxTipo.Name = "ComboBoxTipo";
            this.ComboBoxTipo.Size = new System.Drawing.Size(727, 25);
            this.ComboBoxTipo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Projeto API";
            // 
            // ComboBoxProjetoAPI
            // 
            this.ComboBoxProjetoAPI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxProjetoAPI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxProjetoAPI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxProjetoAPI.BackColor = System.Drawing.SystemColors.Window;
            this.ComboBoxProjetoAPI.DisplayMember = "NOM_PROJETO";
            this.ComboBoxProjetoAPI.FormattingEnabled = true;
            this.ComboBoxProjetoAPI.Location = new System.Drawing.Point(7, 359);
            this.ComboBoxProjetoAPI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxProjetoAPI.Name = "ComboBoxProjetoAPI";
            this.ComboBoxProjetoAPI.Size = new System.Drawing.Size(727, 25);
            this.ComboBoxProjetoAPI.TabIndex = 5;
            this.ComboBoxProjetoAPI.ValueMember = "OID_PROJETO";
            // 
            // TextBoxNamespace
            // 
            this.TextBoxNamespace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxNamespace.Location = new System.Drawing.Point(7, 164);
            this.TextBoxNamespace.Name = "TextBoxNamespace";
            this.TextBoxNamespace.Size = new System.Drawing.Size(727, 23);
            this.TextBoxNamespace.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Namespace";
            // 
            // ButtonProcurarDiretorio
            // 
            this.ButtonProcurarDiretorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonProcurarDiretorio.BackColor = System.Drawing.Color.Gold;
            this.ButtonProcurarDiretorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonProcurarDiretorio.FlatAppearance.BorderSize = 0;
            this.ButtonProcurarDiretorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonProcurarDiretorio.Location = new System.Drawing.Point(703, 101);
            this.ButtonProcurarDiretorio.Name = "ButtonProcurarDiretorio";
            this.ButtonProcurarDiretorio.Size = new System.Drawing.Size(31, 22);
            this.ButtonProcurarDiretorio.TabIndex = 15;
            this.ButtonProcurarDiretorio.UseVisualStyleBackColor = false;
            this.ButtonProcurarDiretorio.Click += new System.EventHandler(this.ButtonProcurarDiretorio_Click);
            // 
            // TextBoxDiretorio
            // 
            this.TextBoxDiretorio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDiretorio.Location = new System.Drawing.Point(7, 102);
            this.TextBoxDiretorio.Name = "TextBoxDiretorio";
            this.TextBoxDiretorio.Size = new System.Drawing.Size(690, 23);
            this.TextBoxDiretorio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Diretório";
            // 
            // ButtonExcluir
            // 
            this.ButtonExcluir.BackColor = System.Drawing.Color.Coral;
            this.ButtonExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonExcluir.FlatAppearance.BorderSize = 0;
            this.ButtonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExcluir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ButtonSalvar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.TextBoxNome.Size = new System.Drawing.Size(727, 23);
            this.TextBoxNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // ListProjetos
            // 
            this.ListProjetos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListProjetos.DisplayMember = "NOM_PROJETO";
            this.ListProjetos.FormattingEnabled = true;
            this.ListProjetos.Location = new System.Drawing.Point(3, 44);
            this.ListProjetos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListProjetos.Name = "ListProjetos";
            this.ListProjetos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListProjetos.Size = new System.Drawing.Size(229, 563);
            this.ListProjetos.TabIndex = 13;
            this.ListProjetos.SelectedIndexChanged += new System.EventHandler(this.ListProjetos_SelectedIndexChanged);
            // 
            // ButtonNovo
            // 
            this.ButtonNovo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNovo.FlatAppearance.BorderSize = 0;
            this.ButtonNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNovo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNovo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonNovo.Location = new System.Drawing.Point(3, 6);
            this.ButtonNovo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonNovo.Name = "ButtonNovo";
            this.ButtonNovo.Size = new System.Drawing.Size(229, 30);
            this.ButtonNovo.TabIndex = 14;
            this.ButtonNovo.Text = "Novo";
            this.ButtonNovo.UseVisualStyleBackColor = false;
            this.ButtonNovo.Click += new System.EventHandler(this.ButtonNovo_Click);
            // 
            // Projetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListProjetos);
            this.Controls.Add(this.ButtonNovo);
            this.Name = "Projetos";
            this.Size = new System.Drawing.Size(981, 613);
            this.Load += new System.EventHandler(this.Projetos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonExcluir;
        private System.Windows.Forms.Button ButtonSalvar;
        private System.Windows.Forms.TextBox TextBoxNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ListProjetos;
        private System.Windows.Forms.Button ButtonNovo;
        private System.Windows.Forms.TextBox TextBoxDiretorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonProcurarDiretorio;
        private System.Windows.Forms.TextBox TextBoxNamespace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboBoxProjetoAPI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBoxTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboBoxSistema;
    }
}
