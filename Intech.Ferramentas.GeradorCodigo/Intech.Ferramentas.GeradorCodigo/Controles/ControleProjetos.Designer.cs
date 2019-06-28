﻿namespace Intech.Ferramentas.GeradorCodigo.Controles
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
            this.ButtonSalvar = new System.Windows.Forms.Button();
            this.ButtonVS = new System.Windows.Forms.Button();
            this.ButtonVSCode = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TextBoxDiretorio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxRepositorio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.ListBoxProjetos.Size = new System.Drawing.Size(173, 355);
            this.ListBoxProjetos.TabIndex = 0;
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
            this.groupBox1.Controls.Add(this.ButtonSalvar);
            this.groupBox1.Controls.Add(this.ButtonVS);
            this.groupBox1.Controls.Add(this.ButtonVSCode);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.TextBoxDiretorio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TextBoxRepositorio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(183, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 383);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações";
            // 
            // ButtonSalvar
            // 
            this.ButtonSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonSalvar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSalvar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonSalvar.Location = new System.Drawing.Point(6, 354);
            this.ButtonSalvar.Name = "ButtonSalvar";
            this.ButtonSalvar.Size = new System.Drawing.Size(64, 23);
            this.ButtonSalvar.TabIndex = 16;
            this.ButtonSalvar.Text = "Salvar";
            this.ButtonSalvar.UseVisualStyleBackColor = false;
            this.ButtonSalvar.Click += new System.EventHandler(this.ButtonSalvar_Click);
            // 
            // ButtonVS
            // 
            this.ButtonVS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonVS.BackColor = System.Drawing.Color.DarkViolet;
            this.ButtonVS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonVS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonVS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonVS.Location = new System.Drawing.Point(188, 325);
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
            this.ButtonVSCode.Location = new System.Drawing.Point(188, 354);
            this.ButtonVSCode.Name = "ButtonVSCode";
            this.ButtonVSCode.Size = new System.Drawing.Size(125, 23);
            this.ButtonVSCode.TabIndex = 14;
            this.ButtonVSCode.Text = "Abrir no VS Code";
            this.ButtonVSCode.UseVisualStyleBackColor = false;
            this.ButtonVSCode.Click += new System.EventHandler(this.ButtonVSCode_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "API",
            "Web",
            "Mobile"});
            this.comboBox1.Location = new System.Drawing.Point(6, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(307, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // TextBoxDiretorio
            // 
            this.TextBoxDiretorio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDiretorio.Enabled = false;
            this.TextBoxDiretorio.Location = new System.Drawing.Point(6, 139);
            this.TextBoxDiretorio.Name = "TextBoxDiretorio";
            this.TextBoxDiretorio.Size = new System.Drawing.Size(307, 20);
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
            this.TextBoxRepositorio.Size = new System.Drawing.Size(307, 20);
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
            // ControleProjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonNovo);
            this.Controls.Add(this.ListBoxProjetos);
            this.Name = "ControleProjetos";
            this.Size = new System.Drawing.Size(505, 394);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxProjetos;
        private System.Windows.Forms.Button ButtonNovo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextBoxRepositorio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxDiretorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ButtonVSCode;
        private System.Windows.Forms.Button ButtonVS;
        private System.Windows.Forms.Button ButtonSalvar;
    }
}