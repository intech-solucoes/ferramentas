namespace Intech.Ferramentas.GeradorCodigo.Controles
{
    partial class ControleProjetos
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
            this.ListBoxProjetos = new System.Windows.Forms.ListBox();
            this.ButtonNovo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBoxNamespace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxSistema = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonGerarService = new System.Windows.Forms.Button();
            this.ButtonProjetosDependentes = new System.Windows.Forms.Button();
            this.ButtonVS = new System.Windows.Forms.Button();
            this.ButtonVSCode = new System.Windows.Forms.Button();
            this.ComboBoxTipo = new System.Windows.Forms.ComboBox();
            this.TextBoxDiretorio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxRepositorio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonSelecionarServices = new System.Windows.Forms.Button();
            this.ComboBoxAPI = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CheckBoxBuild = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxProjetos
            // 
            this.ListBoxProjetos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListBoxProjetos.FormattingEnabled = true;
            this.ListBoxProjetos.Location = new System.Drawing.Point(3, 32);
            this.ListBoxProjetos.Name = "ListBoxProjetos";
            this.ListBoxProjetos.Size = new System.Drawing.Size(173, 563);
            this.ListBoxProjetos.TabIndex = 0;
            this.ListBoxProjetos.SelectedIndexChanged += new System.EventHandler(this.ListBoxProjetos_SelectedIndexChanged);
            // 
            // ButtonNovo
            // 
            this.ButtonNovo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNovo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonNovo.Location = new System.Drawing.Point(3, 3);
            this.ButtonNovo.Name = "ButtonNovo";
            this.ButtonNovo.Size = new System.Drawing.Size(173, 23);
            this.ButtonNovo.TabIndex = 9;
            this.ButtonNovo.Text = "Novo";
            this.ButtonNovo.UseVisualStyleBackColor = false;
            this.ButtonNovo.Click += new System.EventHandler(this.ButtonNovo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CheckBoxBuild);
            this.groupBox1.Controls.Add(this.ComboBoxAPI);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ButtonSelecionarServices);
            this.groupBox1.Controls.Add(this.TextBoxNamespace);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ComboBoxSistema);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ButtonGerarService);
            this.groupBox1.Controls.Add(this.ButtonProjetosDependentes);
            this.groupBox1.Controls.Add(this.ButtonVS);
            this.groupBox1.Controls.Add(this.ButtonVSCode);
            this.groupBox1.Controls.Add(this.ComboBoxTipo);
            this.groupBox1.Controls.Add(this.TextBoxDiretorio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TextBoxRepositorio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(183, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 592);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações";
            // 
            // TextBoxNamespace
            // 
            this.TextBoxNamespace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxNamespace.Enabled = false;
            this.TextBoxNamespace.Location = new System.Drawing.Point(6, 233);
            this.TextBoxNamespace.Name = "TextBoxNamespace";
            this.TextBoxNamespace.Size = new System.Drawing.Size(687, 20);
            this.TextBoxNamespace.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Namespace";
            // 
            // ComboBoxSistema
            // 
            this.ComboBoxSistema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxSistema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSistema.Enabled = false;
            this.ComboBoxSistema.FormattingEnabled = true;
            this.ComboBoxSistema.Items.AddRange(new object[] {
            "API",
            "Web",
            "Mobile"});
            this.ComboBoxSistema.Location = new System.Drawing.Point(6, 186);
            this.ComboBoxSistema.Name = "ComboBoxSistema";
            this.ComboBoxSistema.Size = new System.Drawing.Size(687, 21);
            this.ComboBoxSistema.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Sistema";
            // 
            // ButtonGerarService
            // 
            this.ButtonGerarService.Location = new System.Drawing.Point(6, 343);
            this.ButtonGerarService.Name = "ButtonGerarService";
            this.ButtonGerarService.Size = new System.Drawing.Size(143, 23);
            this.ButtonGerarService.TabIndex = 18;
            this.ButtonGerarService.Text = "Gerar Services";
            this.ButtonGerarService.UseVisualStyleBackColor = true;
            this.ButtonGerarService.Click += new System.EventHandler(this.ButtonGerarService_Click);
            // 
            // ButtonProjetosDependentes
            // 
            this.ButtonProjetosDependentes.Location = new System.Drawing.Point(6, 314);
            this.ButtonProjetosDependentes.Name = "ButtonProjetosDependentes";
            this.ButtonProjetosDependentes.Size = new System.Drawing.Size(143, 23);
            this.ButtonProjetosDependentes.TabIndex = 17;
            this.ButtonProjetosDependentes.Text = "Projetos Dependentes";
            this.ButtonProjetosDependentes.UseVisualStyleBackColor = true;
            this.ButtonProjetosDependentes.Click += new System.EventHandler(this.ButtonProjetosDependentes_Click);
            // 
            // ButtonVS
            // 
            this.ButtonVS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonVS.BackColor = System.Drawing.Color.DarkViolet;
            this.ButtonVS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonVS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonVS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonVS.Location = new System.Drawing.Point(568, 532);
            this.ButtonVS.Name = "ButtonVS";
            this.ButtonVS.Size = new System.Drawing.Size(125, 23);
            this.ButtonVS.TabIndex = 15;
            this.ButtonVS.Text = "Abrir no Visual Studio";
            this.ButtonVS.UseVisualStyleBackColor = false;
            this.ButtonVS.Click += new System.EventHandler(this.ButtonVS_Click);
            // 
            // ButtonVSCode
            // 
            this.ButtonVSCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonVSCode.BackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonVSCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonVSCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonVSCode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonVSCode.Location = new System.Drawing.Point(568, 561);
            this.ButtonVSCode.Name = "ButtonVSCode";
            this.ButtonVSCode.Size = new System.Drawing.Size(125, 23);
            this.ButtonVSCode.TabIndex = 14;
            this.ButtonVSCode.Text = "Abrir no VS Code";
            this.ButtonVSCode.UseVisualStyleBackColor = false;
            this.ButtonVSCode.Click += new System.EventHandler(this.ButtonVSCode_Click);
            // 
            // ComboBoxTipo
            // 
            this.ComboBoxTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTipo.Enabled = false;
            this.ComboBoxTipo.FormattingEnabled = true;
            this.ComboBoxTipo.Items.AddRange(new object[] {
            "API",
            "Web",
            "Mobile"});
            this.ComboBoxTipo.Location = new System.Drawing.Point(6, 91);
            this.ComboBoxTipo.Name = "ComboBoxTipo";
            this.ComboBoxTipo.Size = new System.Drawing.Size(687, 21);
            this.ComboBoxTipo.TabIndex = 13;
            // 
            // TextBoxDiretorio
            // 
            this.TextBoxDiretorio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDiretorio.Enabled = false;
            this.TextBoxDiretorio.Location = new System.Drawing.Point(6, 139);
            this.TextBoxDiretorio.Name = "TextBoxDiretorio";
            this.TextBoxDiretorio.Size = new System.Drawing.Size(687, 20);
            this.TextBoxDiretorio.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Diretório";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tipo de Projeto";
            // 
            // TextBoxRepositorio
            // 
            this.TextBoxRepositorio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxRepositorio.Enabled = false;
            this.TextBoxRepositorio.Location = new System.Drawing.Point(6, 45);
            this.TextBoxRepositorio.Name = "TextBoxRepositorio";
            this.TextBoxRepositorio.Size = new System.Drawing.Size(687, 20);
            this.TextBoxRepositorio.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome Repositório";
            // 
            // ButtonSelecionarServices
            // 
            this.ButtonSelecionarServices.Location = new System.Drawing.Point(6, 372);
            this.ButtonSelecionarServices.Name = "ButtonSelecionarServices";
            this.ButtonSelecionarServices.Size = new System.Drawing.Size(143, 23);
            this.ButtonSelecionarServices.TabIndex = 23;
            this.ButtonSelecionarServices.Text = "Selecionar Services";
            this.ButtonSelecionarServices.UseVisualStyleBackColor = true;
            this.ButtonSelecionarServices.Click += new System.EventHandler(this.ButtonSelecionarServices_Click);
            // 
            // ComboBoxAPI
            // 
            this.ComboBoxAPI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxAPI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAPI.Enabled = false;
            this.ComboBoxAPI.FormattingEnabled = true;
            this.ComboBoxAPI.Items.AddRange(new object[] {
            "API",
            "Web",
            "Mobile"});
            this.ComboBoxAPI.Location = new System.Drawing.Point(6, 278);
            this.ComboBoxAPI.Name = "ComboBoxAPI";
            this.ComboBoxAPI.Size = new System.Drawing.Size(687, 21);
            this.ComboBoxAPI.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "API";
            // 
            // CheckBoxBuild
            // 
            this.CheckBoxBuild.AutoSize = true;
            this.CheckBoxBuild.Checked = true;
            this.CheckBoxBuild.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxBuild.Location = new System.Drawing.Point(155, 347);
            this.CheckBoxBuild.Name = "CheckBoxBuild";
            this.CheckBoxBuild.Size = new System.Drawing.Size(145, 17);
            this.CheckBoxBuild.TabIndex = 26;
            this.CheckBoxBuild.Text = "Executar Build do Projeto";
            this.CheckBoxBuild.UseVisualStyleBackColor = true;
            // 
            // ControleProjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonNovo);
            this.Controls.Add(this.ListBoxProjetos);
            this.Name = "ControleProjetos";
            this.Size = new System.Drawing.Size(885, 603);
            this.Load += new System.EventHandler(this.ControleProjetos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonNovo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextBoxRepositorio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxDiretorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxTipo;
        private System.Windows.Forms.Button ButtonVSCode;
        private System.Windows.Forms.Button ButtonVS;
        private System.Windows.Forms.Button ButtonProjetosDependentes;
        public System.Windows.Forms.ListBox ListBoxProjetos;
        private System.Windows.Forms.Button ButtonGerarService;
        private System.Windows.Forms.ComboBox ComboBoxSistema;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxNamespace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonSelecionarServices;
        private System.Windows.Forms.ComboBox ComboBoxAPI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CheckBoxBuild;
    }
}
