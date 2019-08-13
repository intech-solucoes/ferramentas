namespace Intech.Ferramentas.GeradorCodigo.Controles
{
    partial class ControleUtilitarios
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
            this.ComboBoxConexao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonPWCriarUsuarios = new System.Windows.Forms.Button();
            this.ButtonPWResetarSenhas = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxPSEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxPSCelular = new System.Windows.Forms.TextBox();
            this.ButtonPSSalvarEmailCelular = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBoxConexao
            // 
            this.ComboBoxConexao.DisplayMember = "Database";
            this.ComboBoxConexao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxConexao.FormattingEnabled = true;
            this.ComboBoxConexao.Location = new System.Drawing.Point(9, 28);
            this.ComboBoxConexao.Name = "ComboBoxConexao";
            this.ComboBoxConexao.Size = new System.Drawing.Size(207, 21);
            this.ComboBoxConexao.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Conexão";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(4, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(537, 441);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PrevSystem";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ButtonPWResetarSenhas);
            this.groupBox1.Controls.Add(this.ButtonPWCriarUsuarios);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuários";
            // 
            // ButtonPWCriarUsuarios
            // 
            this.ButtonPWCriarUsuarios.Location = new System.Drawing.Point(6, 20);
            this.ButtonPWCriarUsuarios.Name = "ButtonPWCriarUsuarios";
            this.ButtonPWCriarUsuarios.Size = new System.Drawing.Size(95, 23);
            this.ButtonPWCriarUsuarios.TabIndex = 6;
            this.ButtonPWCriarUsuarios.Text = "Criar Usuários";
            this.ButtonPWCriarUsuarios.UseVisualStyleBackColor = true;
            // 
            // ButtonPWResetarSenhas
            // 
            this.ButtonPWResetarSenhas.Location = new System.Drawing.Point(108, 20);
            this.ButtonPWResetarSenhas.Name = "ButtonPWResetarSenhas";
            this.ButtonPWResetarSenhas.Size = new System.Drawing.Size(106, 23);
            this.ButtonPWResetarSenhas.TabIndex = 7;
            this.ButtonPWResetarSenhas.Text = "Resetar Senhas";
            this.ButtonPWResetarSenhas.UseVisualStyleBackColor = true;
            this.ButtonPWResetarSenhas.Click += new System.EventHandler(this.ButtonPWResetarSenhas_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Location = new System.Drawing.Point(547, 58);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(523, 441);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PrevSystemWeb";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ButtonPSSalvarEmailCelular);
            this.groupBox2.Controls.Add(this.TextBoxPSCelular);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TextBoxPSEmail);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 97);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trocar E-mail e Celular";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "E-mail";
            // 
            // TextBoxPSEmail
            // 
            this.TextBoxPSEmail.Location = new System.Drawing.Point(6, 36);
            this.TextBoxPSEmail.Name = "TextBoxPSEmail";
            this.TextBoxPSEmail.Size = new System.Drawing.Size(238, 20);
            this.TextBoxPSEmail.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Celular";
            // 
            // TextBoxPSCelular
            // 
            this.TextBoxPSCelular.Location = new System.Drawing.Point(264, 36);
            this.TextBoxPSCelular.Name = "TextBoxPSCelular";
            this.TextBoxPSCelular.Size = new System.Drawing.Size(255, 20);
            this.TextBoxPSCelular.TabIndex = 8;
            // 
            // ButtonPSSalvarEmailCelular
            // 
            this.ButtonPSSalvarEmailCelular.Location = new System.Drawing.Point(6, 62);
            this.ButtonPSSalvarEmailCelular.Name = "ButtonPSSalvarEmailCelular";
            this.ButtonPSSalvarEmailCelular.Size = new System.Drawing.Size(113, 23);
            this.ButtonPSSalvarEmailCelular.TabIndex = 9;
            this.ButtonPSSalvarEmailCelular.Text = "Salvar";
            this.ButtonPSSalvarEmailCelular.UseVisualStyleBackColor = true;
            this.ButtonPSSalvarEmailCelular.Click += new System.EventHandler(this.ButtonPSSalvarEmailCelular_Click);
            // 
            // ControleUtilitarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ComboBoxConexao);
            this.Controls.Add(this.label2);
            this.Name = "ControleUtilitarios";
            this.Size = new System.Drawing.Size(1073, 502);
            this.Load += new System.EventHandler(this.ControleUtilitarios_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComboBoxConexao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonPWResetarSenhas;
        private System.Windows.Forms.Button ButtonPWCriarUsuarios;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButtonPSSalvarEmailCelular;
        private System.Windows.Forms.TextBox TextBoxPSCelular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxPSEmail;
        private System.Windows.Forms.Label label1;
    }
}
