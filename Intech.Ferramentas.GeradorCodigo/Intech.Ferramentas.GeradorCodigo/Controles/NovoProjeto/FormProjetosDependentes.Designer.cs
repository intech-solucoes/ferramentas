namespace Intech.Ferramentas.GeradorCodigo.Controles.NovoProjeto
{
    partial class FormProjetosDependentes
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
            this.CheckedListBoxProjetos = new System.Windows.Forms.CheckedListBox();
            this.ButtonSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckedListBoxProjetos
            // 
            this.CheckedListBoxProjetos.CheckOnClick = true;
            this.CheckedListBoxProjetos.FormattingEnabled = true;
            this.CheckedListBoxProjetos.Location = new System.Drawing.Point(13, 13);
            this.CheckedListBoxProjetos.Name = "CheckedListBoxProjetos";
            this.CheckedListBoxProjetos.Size = new System.Drawing.Size(227, 259);
            this.CheckedListBoxProjetos.TabIndex = 0;
            // 
            // ButtonSalvar
            // 
            this.ButtonSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonSalvar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSalvar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonSalvar.Location = new System.Drawing.Point(12, 282);
            this.ButtonSalvar.Name = "ButtonSalvar";
            this.ButtonSalvar.Size = new System.Drawing.Size(227, 23);
            this.ButtonSalvar.TabIndex = 17;
            this.ButtonSalvar.Text = "Salvar";
            this.ButtonSalvar.UseVisualStyleBackColor = false;
            this.ButtonSalvar.Click += new System.EventHandler(this.ButtonSalvar_Click);
            // 
            // FormProjetosDependentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 317);
            this.Controls.Add(this.ButtonSalvar);
            this.Controls.Add(this.CheckedListBoxProjetos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormProjetosDependentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Projetos Dependentes";
            this.Load += new System.EventHandler(this.FormProjetosDependentes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CheckedListBoxProjetos;
        private System.Windows.Forms.Button ButtonSalvar;
    }
}