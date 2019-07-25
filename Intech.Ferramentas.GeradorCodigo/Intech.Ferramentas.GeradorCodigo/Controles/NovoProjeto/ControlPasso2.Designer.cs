namespace Intech.Ferramentas.GeradorCodigo.Controles.NovoProjeto
{
    partial class ControlPasso2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonProcurar = new System.Windows.Forms.Button();
            this.TextBoxDiretorio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxNomeProjeto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RadioButtonAPI = new System.Windows.Forms.RadioButton();
            this.RadioButtonMobile = new System.Windows.Forms.RadioButton();
            this.RadioButtonWeb = new System.Windows.Forms.RadioButton();
            this.ButtonContinuar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboBoxSistemas = new System.Windows.Forms.ComboBox();
            this.TextBoxNamespace = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 381);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2 - Parâmetros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1 - Início";
            // 
            // ButtonProcurar
            // 
            this.ButtonProcurar.Location = new System.Drawing.Point(573, 33);
            this.ButtonProcurar.Name = "ButtonProcurar";
            this.ButtonProcurar.Size = new System.Drawing.Size(64, 21);
            this.ButtonProcurar.TabIndex = 15;
            this.ButtonProcurar.Text = "Procurar";
            this.ButtonProcurar.UseVisualStyleBackColor = true;
            this.ButtonProcurar.Click += new System.EventHandler(this.ButtonProcurar_Click);
            // 
            // TextBoxDiretorio
            // 
            this.TextBoxDiretorio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDiretorio.Location = new System.Drawing.Point(168, 34);
            this.TextBoxDiretorio.Name = "TextBoxDiretorio";
            this.TextBoxDiretorio.Size = new System.Drawing.Size(399, 20);
            this.TextBoxDiretorio.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Diretório do Repositório";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nome do Projeto";
            // 
            // TextBoxNomeProjeto
            // 
            this.TextBoxNomeProjeto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxNomeProjeto.Location = new System.Drawing.Point(168, 83);
            this.TextBoxNomeProjeto.Name = "TextBoxNomeProjeto";
            this.TextBoxNomeProjeto.Size = new System.Drawing.Size(469, 20);
            this.TextBoxNomeProjeto.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tipo do Projeto:";
            // 
            // RadioButtonAPI
            // 
            this.RadioButtonAPI.AutoSize = true;
            this.RadioButtonAPI.Location = new System.Drawing.Point(270, 119);
            this.RadioButtonAPI.Name = "RadioButtonAPI";
            this.RadioButtonAPI.Size = new System.Drawing.Size(42, 17);
            this.RadioButtonAPI.TabIndex = 19;
            this.RadioButtonAPI.TabStop = true;
            this.RadioButtonAPI.Text = "API";
            this.RadioButtonAPI.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMobile
            // 
            this.RadioButtonMobile.AutoSize = true;
            this.RadioButtonMobile.Location = new System.Drawing.Point(329, 119);
            this.RadioButtonMobile.Name = "RadioButtonMobile";
            this.RadioButtonMobile.Size = new System.Drawing.Size(56, 17);
            this.RadioButtonMobile.TabIndex = 20;
            this.RadioButtonMobile.TabStop = true;
            this.RadioButtonMobile.Text = "Mobile";
            this.RadioButtonMobile.UseVisualStyleBackColor = true;
            // 
            // RadioButtonWeb
            // 
            this.RadioButtonWeb.AutoSize = true;
            this.RadioButtonWeb.Location = new System.Drawing.Point(401, 119);
            this.RadioButtonWeb.Name = "RadioButtonWeb";
            this.RadioButtonWeb.Size = new System.Drawing.Size(48, 17);
            this.RadioButtonWeb.TabIndex = 21;
            this.RadioButtonWeb.TabStop = true;
            this.RadioButtonWeb.Text = "Web";
            this.RadioButtonWeb.UseVisualStyleBackColor = true;
            // 
            // ButtonContinuar
            // 
            this.ButtonContinuar.Location = new System.Drawing.Point(168, 341);
            this.ButtonContinuar.Name = "ButtonContinuar";
            this.ButtonContinuar.Size = new System.Drawing.Size(75, 23);
            this.ButtonContinuar.TabIndex = 22;
            this.ButtonContinuar.Text = "Continuar";
            this.ButtonContinuar.UseVisualStyleBackColor = true;
            this.ButtonContinuar.Click += new System.EventHandler(this.ButtonContinuar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Sistema";
            // 
            // ComboBoxSistemas
            // 
            this.ComboBoxSistemas.FormattingEnabled = true;
            this.ComboBoxSistemas.Location = new System.Drawing.Point(168, 165);
            this.ComboBoxSistemas.Name = "ComboBoxSistemas";
            this.ComboBoxSistemas.Size = new System.Drawing.Size(185, 21);
            this.ComboBoxSistemas.TabIndex = 24;
            // 
            // TextBoxNamespace
            // 
            this.TextBoxNamespace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxNamespace.Location = new System.Drawing.Point(168, 212);
            this.TextBoxNamespace.Name = "TextBoxNamespace";
            this.TextBoxNamespace.Size = new System.Drawing.Size(469, 20);
            this.TextBoxNamespace.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Namespace";
            // 
            // ControlPasso2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBoxNamespace);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComboBoxSistemas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ButtonContinuar);
            this.Controls.Add(this.RadioButtonWeb);
            this.Controls.Add(this.RadioButtonMobile);
            this.Controls.Add(this.RadioButtonAPI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxNomeProjeto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonProcurar);
            this.Controls.Add(this.TextBoxDiretorio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "ControlPasso2";
            this.Size = new System.Drawing.Size(652, 381);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonProcurar;
        private System.Windows.Forms.TextBox TextBoxDiretorio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxNomeProjeto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton RadioButtonAPI;
        private System.Windows.Forms.RadioButton RadioButtonMobile;
        private System.Windows.Forms.RadioButton RadioButtonWeb;
        private System.Windows.Forms.Button ButtonContinuar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboBoxSistemas;
        private System.Windows.Forms.TextBox TextBoxNamespace;
        private System.Windows.Forms.Label label7;
    }
}
