﻿namespace Intech.Ferramentas.GeradorCodigo.Controles
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonResetarSenhas = new System.Windows.Forms.Button();
            this.ButtonCriarUsuarios = new System.Windows.Forms.Button();
            this.ComboBoxConexao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.TextBoxCelular = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonSalvarEmailCelular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ButtonResetarSenhas);
            this.groupBox1.Controls.Add(this.ButtonCriarUsuarios);
            this.groupBox1.Location = new System.Drawing.Point(3, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuários PrevSystemWeb";
            // 
            // ButtonResetarSenhas
            // 
            this.ButtonResetarSenhas.Location = new System.Drawing.Point(108, 30);
            this.ButtonResetarSenhas.Name = "ButtonResetarSenhas";
            this.ButtonResetarSenhas.Size = new System.Drawing.Size(106, 23);
            this.ButtonResetarSenhas.TabIndex = 7;
            this.ButtonResetarSenhas.Text = "Resetar Senhas";
            this.ButtonResetarSenhas.UseVisualStyleBackColor = true;
            // 
            // ButtonCriarUsuarios
            // 
            this.ButtonCriarUsuarios.Location = new System.Drawing.Point(6, 30);
            this.ButtonCriarUsuarios.Name = "ButtonCriarUsuarios";
            this.ButtonCriarUsuarios.Size = new System.Drawing.Size(95, 23);
            this.ButtonCriarUsuarios.TabIndex = 6;
            this.ButtonCriarUsuarios.Text = "Criar Usuários";
            this.ButtonCriarUsuarios.UseVisualStyleBackColor = true;
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ButtonSalvarEmailCelular);
            this.groupBox2.Controls.Add(this.TextBoxCelular);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TextBoxEmail);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(689, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trocar E-mail e Celular";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "E-mail";
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(6, 36);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(207, 20);
            this.TextBoxEmail.TabIndex = 6;
            // 
            // TextBoxCelular
            // 
            this.TextBoxCelular.Location = new System.Drawing.Point(219, 36);
            this.TextBoxCelular.Name = "TextBoxCelular";
            this.TextBoxCelular.Size = new System.Drawing.Size(207, 20);
            this.TextBoxCelular.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Celular";
            // 
            // ButtonSalvarEmailCelular
            // 
            this.ButtonSalvarEmailCelular.Location = new System.Drawing.Point(432, 34);
            this.ButtonSalvarEmailCelular.Name = "ButtonSalvarEmailCelular";
            this.ButtonSalvarEmailCelular.Size = new System.Drawing.Size(113, 23);
            this.ButtonSalvarEmailCelular.TabIndex = 9;
            this.ButtonSalvarEmailCelular.Text = "Salvar";
            this.ButtonSalvarEmailCelular.UseVisualStyleBackColor = true;
            this.ButtonSalvarEmailCelular.Click += new System.EventHandler(this.ButtonSalvarEmailCelular_Click);
            // 
            // ControleUtilitarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ComboBoxConexao);
            this.Controls.Add(this.label2);
            this.Name = "ControleUtilitarios";
            this.Size = new System.Drawing.Size(696, 484);
            this.Load += new System.EventHandler(this.ControleUtilitarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonResetarSenhas;
        private System.Windows.Forms.Button ButtonCriarUsuarios;
        private System.Windows.Forms.ComboBox ComboBoxConexao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButtonSalvarEmailCelular;
        private System.Windows.Forms.TextBox TextBoxCelular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Label label1;
    }
}
