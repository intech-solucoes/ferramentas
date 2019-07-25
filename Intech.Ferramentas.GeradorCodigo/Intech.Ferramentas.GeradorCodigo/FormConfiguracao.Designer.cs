namespace Intech.Ferramentas.GeradorCodigo
{
    partial class FormConfiguracao
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
            this.ButtonSalvar = new System.Windows.Forms.Button();
            this.TextBoxDiretorioGIT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ButtonProcurar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonSalvar
            // 
            this.ButtonSalvar.Location = new System.Drawing.Point(12, 74);
            this.ButtonSalvar.Name = "ButtonSalvar";
            this.ButtonSalvar.Size = new System.Drawing.Size(75, 23);
            this.ButtonSalvar.TabIndex = 3;
            this.ButtonSalvar.Text = "Salvar";
            this.ButtonSalvar.UseVisualStyleBackColor = true;
            this.ButtonSalvar.Click += new System.EventHandler(this.ButtonSalvar_Click);
            // 
            // TextBoxDiretorioGIT
            // 
            this.TextBoxDiretorioGIT.Location = new System.Drawing.Point(12, 25);
            this.TextBoxDiretorioGIT.Name = "TextBoxDiretorioGIT";
            this.TextBoxDiretorioGIT.Size = new System.Drawing.Size(386, 20);
            this.TextBoxDiretorioGIT.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Diretório do Repositório";
            // 
            // ButtonProcurar
            // 
            this.ButtonProcurar.Location = new System.Drawing.Point(404, 24);
            this.ButtonProcurar.Name = "ButtonProcurar";
            this.ButtonProcurar.Size = new System.Drawing.Size(75, 21);
            this.ButtonProcurar.TabIndex = 10;
            this.ButtonProcurar.Text = "Procurar";
            this.ButtonProcurar.UseVisualStyleBackColor = true;
            this.ButtonProcurar.Click += new System.EventHandler(this.ButtonProcurar_Click);
            // 
            // FormConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 107);
            this.Controls.Add(this.ButtonProcurar);
            this.Controls.Add(this.TextBoxDiretorioGIT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ButtonSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormConfiguracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuração";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConfiguracao_FormClosing);
            this.Load += new System.EventHandler(this.FormConfiguracao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonSalvar;
        private System.Windows.Forms.TextBox TextBoxDiretorioGIT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ButtonProcurar;
    }
}